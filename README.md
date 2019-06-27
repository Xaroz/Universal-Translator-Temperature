# UniversalTranslatorTemperature
Project for Tendencias en Desarrollo de Aplicaciones where you can convert from one temperature unit to another.

## How it works

#### You must pass a .txt file with the following characteristics: 
* Value: the value you wish to convert, must be a number input.
* Origin Unit: The temperature unit that the value is originating from: C for Celsius scale , K for Kelvin scale, F for Fahrenheit scale.
* Converted Unit: The temperature unit that you wish to convert to, again: C for Celsius scale , K for Kelvin scale, F for Fahrenheit scale.

#### Each element must be separated by an space and each line represents a different unit you wish to convert.
#### The program will create a txt file with the same elements as the input file including an extra element which is the value that the initial value is converted to.

## Prerequisites

* Visual Studio 2017 or newer
* NetCore extension installed

## CRC Cards
![Temperature](https://github.com/Xaroz/UniversalTranslatorTemperature/blob/master/TemperatureCRC.jpg "Temperature CRC")
![ConvertTemperature](https://github.com/Xaroz/UniversalTranslatorTemperature/blob/master/ConvertTemperature.jpg "ConvertTemperature CRC")
