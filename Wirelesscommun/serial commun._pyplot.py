import serial as sr
import numpy as np
import matplotlib.pyplot as plt
import time

s = sr.Serial('COM4', baudrate = 9600, timeout=1)
time.sleep(1)
count = 10
dataFile = open('dataFile.txt', 'w')

plt.close('all')
plt.figure()
plt.ion() 


time = np.array([])
data1 = np.array([])
data2 = np.array([])
data3 = np.array([])
data4 = np.array([])
data5 = np.array([])
data6 = np.array([])
t=0

while t < 10:     
    a = s.readline()
    a.decode()
    dataFile.write(a.decode()[:-1])
    dataset = a.decode()[:-2].split(' ')
    t = float(dataset[0])
    v1 = float(dataset[1])
    v2 = float(dataset[2])
    v3 = float(dataset[3])
    v4 = float(dataset[4])
    v5 = float(dataset[5])
    v6 = float(dataset[6])
    time = np.append(time, t)
    data1 = np.append(data1, v1)
    data2 = np.append(data2, v2)
    data3 = np.append(data3, v3)
    data4 = np.append(data4, v4)
    data5 = np.append(data5, v5)
    data6 = np.append(data6, v6)
    plt.cla()
    plt.plot(time, data1, label = "sensor1")
    plt.plot(time, data2, label = "sensor2")
    plt.plot(time, data3, label = "sensor3")
    plt.plot(time, data4, label = "sensor4")
    plt.plot(time, data5, label = "sensor5")
    plt.plot(time, data6, label = "sensor6")
    plt.plot(time, data1, data2, data3)
    plt.xlim(0,10)
    plt.ylim(-6,2)
    plt.xlabel('Time(sec)')
    plt.ylabel('Voltage(V)')
    plt.title('E-skin sensor')
    plt.legend(loc = 'upper right')
    plt.pause(0.01)
    
       
plt.show()
dataFile.close()
s.close()
    
