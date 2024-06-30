using HomeWork1of2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1of2Tests
{
    [TestClass]
    public class MathHandlerFactorialTests
    {
        [TestMethod]
        public void Factorial_WithZero_ReturnsOne()
        {
            int input = 0;
            int expected = 1;
            int actual = MathHandler.Factorial(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Factorial_WithOne_ReturnsOne()
        {
            int input = 1;
            int expected = 1;
            int actual = MathHandler.Factorial(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Factorial_WithTwo_ReturnsTwo()
        {
            int input = 2;
            int expected = 2;
            int actual = MathHandler.Factorial(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Factorial_WithThree_ReturnsSix()
        {
            int input = 3;
            int expected = 6;
            int actual = MathHandler.Factorial(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Factorial_WithFour_ReturnsTwentyFour()
        {
            int input = 4;
            int expected = 24;
            int actual = MathHandler.Factorial(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Factorial_WithFive_ReturnsOneHundredTwenty()
        {
            int input = 5;
            int expected = 120;
            int actual = MathHandler.Factorial(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Factorial_WithNegativeNumber_ThrowsArgumentException()
        {
            int input = -1;
            MathHandler.Factorial(input);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void Factorial_WithLargeNumber_ThrowsOverflowException()
        {
            int input = 21;
            MathHandler.Factorial(input);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void Factorial_WithMaxValue_ThrowsOverflowException()
        {
            int input = int.MaxValue;
            MathHandler.Factorial(input);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Factorial_WithMinValue_ThrowsArgumentException()
        {
            int input = int.MinValue;
            MathHandler.Factorial(input);
        }
    }
}
