#include <RFduinoGZLL.h>
device_t role = DEVICE0;

int analogIns[] = {1, 2, 3, 4, 5, 6};
float sensor[] = {0.00, 0.00, 0.00, 0.00, 0.00};
String nameArray[] = {"sensor1:", "sensor2:", "sensor3:", "sensor4:", "sensor5:", "sensor6:"};
char v1[6][10] = {{""}, {""}, {""}, {""}, {""}, {""}};
char v2[3][20] = {{""}, {""}, {""}};
char v3[30] = {""};
int numInputs = 6;
int count;
float sensitivity = 0.90;
int pCount;
int myDelay = 0.01;
unsigned long currentTime = 0.0;

void setup() {
  // put your setup code here, to run once:
   Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
    currentTime = millis();
    for(count = 0; count < numInputs; count++){
        sensor[count] = analogRead(analogIns[count]);
        for (int i = 0; i < 300; i++) {
            sensor[count] += analogRead(analogIns[count]);
            delayMicroseconds(0.001);
        }    
        sensor[count] /= 300;
        sensor[count] = (sensor[count]*5.00) / 1024.0 - count;
        sensor[count] = sensor[count]*(1 - sensitivity) + sensor[count]*sensitivity;
        int sensor_int = int(sensor[count]);
        float sensor_float = (abs(sensor[count]) - abs(sensor[count])) * 100;
        int sensor_flt = int(sensor_float);
        sprintf(v1[count], "%d.%d", sensor_int, sensor_flt);
    }  
//    Serial.print(currentTime);
//    Serial.print(" "); 
    sprintf(v2[0], "%s%s", v1[0], v1[1]);
    sprintf(v2[1], "%s%s", v1[2], v1[3]);
    sprintf(v2[2], "%s%s", v1[4], v1[5]);
    sprintf(v3, "%s%s", v2[0], v2[1], v2[3]);


    
    for(pCount = 0; pCount < numInputs; pCount++){
        Serial.print(nameArray[pCount/2]);
        Serial.print(sensor[pCount/2]);
        Serial.print(" ");       
    }
    Serial.println();
    RFduinoGZLL.sendToHost(v2[0]);
    RFduinoGZLL.sendToHost(v2[1]);
    RFduinoGZLL.sendToHost(v2[2]);
    delayMicroseconds(myDelay);    
}
