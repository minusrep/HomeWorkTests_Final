using HomeWork1of2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1of2Tests
{
    [TestClass]
    public class MathHandlerTriangleAreaTests
    {
        [TestMethod]
        public void TestOrdinaryTriangle()
        {
            float a = 3, b = 4, c = 5;
            float expectedArea = 6.0f;
            float actualArea = MathHandler.TriangleArea(a, b, c);
            Assert.AreEqual(expectedArea, actualArea, 0.001f, "Area calculation failed for ordinary triangle.");
        }

        [TestMethod]
        public void TestEquilateralTriangle()
        {
            float a = 5, b = 5, c = 5;
            float expectedArea = 10.825f;
            float actualArea = MathHandler.TriangleArea(a, b, c);
            Assert.AreEqual(expectedArea, actualArea, 0.001f, "Area calculation failed for equilateral triangle.");
        }

        [TestMethod]
        public void TestSmallSidedTriangle()
        {
            float a = 0.1f, b = 0.1f, c = 0.1f;
            float expectedArea = 0.004f;
            float actualArea = MathHandler.TriangleArea(a, b, c);
            Assert.AreEqual(expectedArea, actualArea, 0.001f, "Area calculation failed for small sided triangle.");
        }

        [TestMethod]
        public void TestSidesTendingToZero()
        {
            float a = 0.0001f, b = 0.0001f, c = 0.0001f;
            float expectedArea = 0.0f;
            float actualArea = MathHandler.TriangleArea(a, b, c);
            Assert.AreEqual(expectedArea, actualArea, 0.001f, "Area calculation failed for sides tending to zero.");
        }

        [TestMethod]
        public void TestLargeSidedTriangle()
        {
            float a = 1000, b = 1000, c = 1000;
            float expectedArea = 433012.701f;
            float actualArea = MathHandler.TriangleArea(a, b, c);
            Assert.AreEqual(expectedArea, actualArea, 0.1f, "Area calculation failed for large sided triangle.");
        }

        [TestMethod]
        public void TestNonIntegerSidedTriangle()
        {
            float a = 3.5f, b = 4.5f, c = 5.5f;
            float expectedArea = 7.854f;
            float actualArea = MathHandler.TriangleArea(a, b, c);
            Assert.AreEqual(expectedArea, actualArea, 0.01f, "Area calculation failed for non-integer sided triangle.");
        }

        [TestMethod]
        public void TestOneVeryLargeSide()
        {
            float a = 1, b = 1, c = 100;
            Assert.ThrowsException<ArgumentException>(() => MathHandler.TriangleArea(a, b, c), "Expected exception not thrown for one very large side.");
        }

        [TestMethod]
        public void TestOneVerySmallSide()
        {
            float a = 100f, b = 100f, c = 1f;
            float expectedArea = 50f;
            float actualArea = MathHandler.TriangleArea(a, b, c);
            Assert.AreEqual(expectedArea, actualArea, 0.1f, "Area calculation failed for non-integer sided triangle.");
        }

        [TestMethod]
        public void TestZeroSidedTriangle()
        {
            float a = 0, b = 4, c = 5;
            Assert.ThrowsException<ArgumentException>(() => MathHandler.TriangleArea(a, b, c), "Expected exception not thrown for zero sided triangle.");
        }
        [TestMethod]
        public void TestZeroTriangle()
        {
            float a = 0f, b = 0f, c = 0f;
            Assert.ThrowsException<ArgumentException>(() => MathHandler.TriangleArea(a, b, c), "Expected exception not thrown for zero sided triangle.");
        }
    }
}
