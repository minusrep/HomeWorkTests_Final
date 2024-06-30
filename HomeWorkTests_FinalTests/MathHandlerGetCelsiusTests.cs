using HomeWork1of2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1of2Tests
{
    [TestClass]
    public class MathHandlerGetCelsiusTests
    {

        [TestMethod]
        public void TestGetCelsius_ThirtyTwoFahrenheit()
        {
            float fahrenheit = 32;
            float expectedCelsius = 0;
            float actualCelsius = MathHandler.GetCelsius(fahrenheit);
            Assert.AreEqual(expectedCelsius, actualCelsius, 0.001);
        }

        [TestMethod]
        public void TestGetCelsius_NegativeFortyFahrenheit()
        {
            float fahrenheit = -40;
            float expectedCelsius = -40;
            float actualCelsius = MathHandler.GetCelsius(fahrenheit);
            Assert.AreEqual(expectedCelsius, actualCelsius, 0.001);
        }

        [TestMethod]
        public void TestGetCelsius_TwoHundredTwelveFahrenheit()
        {
            float fahrenheit = 212;
            float expectedCelsius = 100;
            float actualCelsius = MathHandler.GetCelsius(fahrenheit);
            Assert.AreEqual(expectedCelsius, actualCelsius, 0.001);
        }

        [TestMethod]
        public void TestGetCelsius_BodyTemperatureFahrenheit()
        {
            float fahrenheit = 98.6f;
            float expectedCelsius = 37;
            float actualCelsius = MathHandler.GetCelsius(fahrenheit);
            Assert.AreEqual(expectedCelsius, actualCelsius, 0.001);
        }

        [TestMethod]
        public void TestGetCelsius_AbsoluteZeroFahrenheit()
        {
            float fahrenheit = -459.67f;
            float expectedCelsius = -273.15f;
            float actualCelsius = MathHandler.GetCelsius(fahrenheit);
            Assert.AreEqual(expectedCelsius, actualCelsius, 0.001);
        }
    }
}
