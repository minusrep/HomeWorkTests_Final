using HomeWork1of2;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1of2Tests
{
    [TestClass]
    public class MathHandlerAverageTests
    {
        [TestMethod]
        public void Average_WithValidNumbers_ReturnsCorrectAverage()
        {
            var numbers = new float[] { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f };
            float expected = 3.0f;
            float actual = MathHandler.Average(numbers);
            Assert.AreEqual(expected, actual, 0.0001f);
        }

        [TestMethod]
        public void Average_WithSingleNumber_ReturnsTheNumber()
        {
            var numbers = new float[] { 7.0f };
            float expected = 7.0f;
            float actual = MathHandler.Average(numbers);
            Assert.AreEqual(expected, actual, 0.0001f);
        }

        [TestMethod]
        public void Average_WithNegativeNumbers_ReturnsCorrectAverage()
        {
            var numbers = new float[] { -1.0f, -2.0f, -3.0f, -4.0f, -5.0f };
            float expected = -3.0f;
            float actual = MathHandler.Average(numbers);
            Assert.AreEqual(expected, actual, 0.0001f);
        }

        [TestMethod]
        public void Average_WithMixedNumbers_ReturnsCorrectAverage()
        {
            var numbers = new float[] { -1.0f, 2.0f, -3.0f, 4.0f, -5.0f };
            float expected = -0.6f;
            float actual = MathHandler.Average(numbers);
            Assert.AreEqual(expected, actual, 0.0001f);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Average_WithEmptyList_ThrowsArgumentException()
        {
            var numbers = new float[] { };
            MathHandler.Average(numbers);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Average_WithNullList_ThrowsArgumentException()
        {
            float[] numbers = null;
            MathHandler.Average(numbers);
        }

        [TestMethod]
        public void Average_WithZeroes_ReturnsZero()
        {
            var numbers = new float[] { 0.0f, 0.0f, 0.0f };
            float expected = 0.0f;
            float actual = MathHandler.Average(numbers);
            Assert.AreEqual(expected, actual, 0.0001f);
        }

        [TestMethod]
        public void Average_WithLargeNumbers_ReturnsCorrectAverage()
        {
            var numbers = new float[] { 1000000.0f, 2000000.0f, 3000000.0f };
            float expected = 2000000.0f;
            float actual = MathHandler.Average(numbers);
            Assert.AreEqual(expected, actual, 0.0001f);
        }

        [TestMethod]
        public void Average_WithDecimalNumbers_ReturnsCorrectAverage()
        {
            var numbers = new float[] { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f };
            float expected = 3.3f;
            float actual = MathHandler.Average(numbers);
            Assert.AreEqual(expected, actual, 0.0001f);
        }

        [TestMethod]
        public void Average_WithSameNumbers_ReturnsTheNumber()
        {
            var numbers = new float[] { 4.0f, 4.0f, 4.0f };
            float expected = 4.0f;
            float actual = MathHandler.Average(numbers);
            Assert.AreEqual(expected, actual, 0.0001f);
        }
    }

}

