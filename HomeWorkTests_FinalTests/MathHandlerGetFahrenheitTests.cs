using HomeWork1of2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1of2Tests
{
    [TestClass]
    public class MathHandlerGetFahrenheitTests
    {
        [TestMethod]
        public void TestGetFahrenheit_ZeroCelsius()
        {
            float celsius = 0;
            float expectedFahrenheit = 32;
            float actualFahrenheit = MathHandler.GetFahrenheit(celsius);
            Assert.AreEqual(expectedFahrenheit, actualFahrenheit, 0.001);
        }

        [TestMethod]
        public void TestGetFahrenheit_NegativeFortyCelsius()
        {
            float celsius = -40;
            float expectedFahrenheit = -40;
            float actualFahrenheit = MathHandler.GetFahrenheit(celsius);
            Assert.AreEqual(expectedFahrenheit, actualFahrenheit, 0.001);
        }

        [TestMethod]
        public void TestGetFahrenheit_HundredCelsius()
        {
            float celsius = 100;
            float expectedFahrenheit = 212;
            float actualFahrenheit = MathHandler.GetFahrenheit(celsius);
            Assert.AreEqual(expectedFahrenheit, actualFahrenheit, 0.001);
        }

        [TestMethod]
        public void TestGetFahrenheit_BodyTemperatureCelsius()
        {
            float celsius = 37;
            float expectedFahrenheit = 98.6f;
            float actualFahrenheit = MathHandler.GetFahrenheit(celsius);
            Assert.AreEqual(expectedFahrenheit, actualFahrenheit, 0.001);
        }

        [TestMethod]
        public void TestGetFahrenheit_AbsoluteZeroCelsius()
        {
            float celsius = -273.15f;
            float expectedFahrenheit = -459.67f;
            float actualFahrenheit = MathHandler.GetFahrenheit(celsius);
            Assert.AreEqual(expectedFahrenheit, actualFahrenheit, 0.001);
        }
    }
}
