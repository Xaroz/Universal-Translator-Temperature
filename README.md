# UniversalTranslatorTemperature
Project for Tendencias en Desarrollo de Aplicaciones where you can convert from one temperature unit to another.

## How it works

#### The program will ask you to write the directory of the text file you wish to convert.
#### You must pass .txt file with the following characteristics: 
* Value: the value you wish to convert, must be a number input.
* Origin Unit: The temperature unit that the value is originating from: C for Celsius scale , K for Kelvin scale, F for Fahrenheit scale.
* Converted Unit: The temperature unit that you wish to convert to, again: C for Celsius scale , K for Kelvin scale, F for Fahrenheit scale.

#### Each element must be separated by an space and each line represents a different unit you wish to convert, no empty spaces nor empty lines are allowed
#### Finally the program will ask you to write the directory of the text file you wish to place the converted temperatures.
#### If the file does not exist the the program will create it for you in the the same directory
#### The resulting .txt file will have almost the same elements as the initial file: initial value, origin unit, converted value and converted unit.

## Prerequisites

* Visual Studio 2017 or newer
* NetCore extension installed

##How to run the program

#### To run the project you must open the solution through Visual Studio then simply run the project TemperatureConverter for it to work, remember to have all the prerequisites installed.

## CRC Cards
![InputReader](https://github.com/Xaroz/UniversalTranslatorTemperature/blob/master/InputReader.jpg "InputReader CRC")
![TemperatureConvert](https://github.com/Xaroz/UniversalTranslatorTemperature/blob/master/TemperatureConvertCRC.jpg "TemperatureConvert CRC")

## UML Class Diagram
![Class Diagram](https://github.com/Xaroz/UniversalTranslatorTemperature/blob/master/ClassDiagram.jpg "Class Diagram")
