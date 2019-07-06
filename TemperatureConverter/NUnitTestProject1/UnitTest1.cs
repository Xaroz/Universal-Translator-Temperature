using NUnit.Framework;
using TemperatureConverter;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void With_1_Celsius_To_Kelvin()
        {
            TemperatureConvert temperatureConverter = new TemperatureConvert();
            string actual = temperatureConverter.ConvertTemperature(1, "C", "K");

            string expected = "1 C 274.15 K";

            Assert.AreEqual(expected, actual);        
        }

        [Test]
        public void With_15_Celsius_To_Kelvin()
        {
            TemperatureConvert temperatureConverter = new TemperatureConvert();
            string actual = temperatureConverter.ConvertTemperature(15, "C", "K");

            string expected = "15 C 288.15 K";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void With_288point15_Kelvin_To_Celsius()
        {
            TemperatureConvert temperatureConverter = new TemperatureConvert();
            string actual = temperatureConverter.ConvertTemperature(288.15, "K", "C");

            string expected = "288.15 K 15 C";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void With_1_Kelvin_To_Fahrenheit()
        {
            TemperatureConvert temperatureConverter = new TemperatureConvert();
            string actual = temperatureConverter.ConvertTemperature(1, "K", "F");

            string expected = "1 K -457.87 F";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void With_102_Kelvin_To_Fahrenheit()
        {
            TemperatureConvert temperatureConverter = new TemperatureConvert();
            string actual = temperatureConverter.ConvertTemperature(102, "K", "F");

            string expected = "102 K -276.07 F";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void With_Minus276Point07_Fahrenheit_To_Kelvin()
        {
            TemperatureConvert temperatureConverter = new TemperatureConvert();
            string actual = temperatureConverter.ConvertTemperature(-276.07, "F", "K");

            string expected = "-276.07 F 102 K";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void With_1_Celsius_To_Fahrenheit()
        {
            TemperatureConvert temperatureConverter = new TemperatureConvert();
            string actual = temperatureConverter.ConvertTemperature(1, "C", "F");

            string expected = "1 C 33.8 F";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void With_18_Celsius_To_Fahrenheit()
        {
            TemperatureConvert temperatureConverter = new TemperatureConvert();
            string actual = temperatureConverter.ConvertTemperature(18, "C", "F");

            string expected = "18 C 64.4 F";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void With_64Point4_Fahrenheit_To_Celsius()
        {
            TemperatureConvert temperatureConverter = new TemperatureConvert();
            string actual = temperatureConverter.ConvertTemperature(64.4, "F", "C");

            string expected = "64.4 F 18 C";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void With_Minus15_Fahrenheit_To_Celsius()
        {
            TemperatureConvert temperatureConverter = new TemperatureConvert();
            string actual = temperatureConverter.ConvertTemperature(-15, "F", "C");

            string expected = "-15 F -26.1111111111111 C";

            Assert.AreEqual(expected, actual);
        }
    }
}