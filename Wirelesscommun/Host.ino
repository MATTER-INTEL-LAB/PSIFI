/*
This sketch demonstrates how to send data from a Device
to a Host in a Gazell network.

The host and upto 3 devices should have the RGB shield
attached.  When Button A on a Device is pressed, the
associated led on the Host will toggle.  Device1 is
associated with the Red led, Device2 with the Green led
and Device3 with the Blue led.

The Green led on the Device will blink to indicate
that an acknowledgement from the Host was received.
*/

#include <RFduinoGZLL.h>

device_t role = HOST;

void setup()
{
  Serial.begin(9600);
  
  // start the GZLL stack
  RFduinoGZLL.begin(role);
  Serial.println("rv_1,rv_2,rv_3,rv_4,rv_5,rv_6");
}

void loop()
{

}

void RFduinoGZLL_onReceive(device_t device, int rssi, char *data, int len)
  {
  char v1[20] = {""};
  // ignore acknowledgement without payload
  if (len <= 8){
    sprintf(v1, "%c%c%c%c %c%c%c%c", 
    data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7]);
    Serial.print(v1);
    Serial.print(" ");
  }
  if (len > 8){
    sprintf(v1, "%c%c%c%c %c%c%c%c", 
    data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7]);
    Serial.println(v1);
  }
  
  }
