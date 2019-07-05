using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureConverter
{
    public class TemperatureConverter
    {
        public string ConvertTemperature(double value, string actual_unit, string converted_unit)
        {
            // C is for Celsius, F is for Fahrenheit and K is for Kelvin
            double converted_value = 0;

            if (actual_unit == "C" && converted_unit == "F")
                converted_value = ((9 * value) / 5) + 32;
            else if (actual_unit == "F" && converted_unit == "C")
                converted_value = (5 * (value - 32)) / 9;
            else if (actual_unit == "C" && converted_unit == "K")
                converted_value = value + 273.15;
            else if (actual_unit == "K" && converted_unit == "C")
                converted_value = value - 273.15;
            else if (actual_unit == "F" && converted_unit == "K")
                converted_value = ((5 * (value - 32)) / 9) + 273.15;
            else if (actual_unit == "K" && converted_unit == "F")
                converted_value = ((9 * (value - 273.15)) / 5) + 32;
            else
                converted_value = value;

            string value_string = Convert.ToString(value);
            string converted_value_string = Convert.ToString(converted_value);

            string result = value_string + " " + actual_unit + " " + converted_value_string + " " + converted_unit;
            return result;
        }
    }
}
