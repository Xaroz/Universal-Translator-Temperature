using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TemperatureConverter
{
    public class InputReader
    {
        // C:\Users\jheis\Desktop\TemperatureTester\Test.txt
        // C:\Users\jheis\Desktop\TemperatureTester\ConvertedResult.txt
        List<string> lines;
        List<string> ConvertedList = new List<string>();
        public void ReadLines()
        {
            Console.WriteLine("Please write the directory where your file is located.");
            string dir = Console.ReadLine();          
            try
            {
                lines = new List<string>(File.ReadAllLines(dir));
            }
            catch
            {
                throw new InvalidPathException();
            }

            if (lines.Count == 0)
                throw new EmptyFileException();  
            
            CheckFormatAndConvert(lines);

            Console.WriteLine("Please write the file where you wish to place the converted temperatures.");
            dir = Console.ReadLine();
            try
            {
                File.WriteAllLines(dir, ConvertedList);
            }
            catch
            {
                throw new InvalidPathException();
            }
            return;
        }

        private void CheckFormatAndConvert(List<string> lines)
        {
            int counter = 1;
            TemperatureConvert temperatureConverter = new TemperatureConvert();
            foreach(string line in lines)
            {
                //splitting the list by space
                string[] to_convert = line.Split(" ");

                //the information to convert must be exactly 3
                if(to_convert.Length != 3)
                {
                    Console.WriteLine("Your input is in incorrect format at line {0}", counter);
                    throw new IncorrectFormatException();
                }
                
                //first element must be a number
                double value;
                try
                {
                    value = Convert.ToDouble(to_convert[0]);
                }
                catch
                {
                    Console.WriteLine("Your first element must be a number at line {0}!", counter);
                    throw new IncorrectFormatException();
                }

                //check if second element is correct
                if(to_convert[1] != "C" && to_convert[1] != "K" && to_convert[1] != "F")
                {
                    Console.WriteLine("Your second element must be C, K or F at line {0}!", counter);
                    throw new IncorrectFormatException();
                }
                //check if third element is correct
                if (to_convert[2] == "C" && to_convert[2] == "K" && to_convert[2] == "F")
                {
                    Console.WriteLine("Your third element must be C, K or F at line {0}!", counter);
                    throw new IncorrectFormatException();
                }

                string result = temperatureConverter.ConvertTemperature(value, to_convert[1], to_convert[2]);
                ConvertedList.Add(result);
                counter++;
            }
            return;
        }       
    }
}
