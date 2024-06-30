using HomeWork1of2;

namespace HomeWork1of2Tests
{
    [TestClass]
    public class MathHandlerFindRootsTests
    {
        [TestMethod]
        public void TestPositiveDiscriminant_APositive_CPositive_BNegative()
        {
            float a = 1;
            float b = -3;
            float c = 2;
            float[] expected = { 2, 1 };
            float[] result = MathHandler.FindRoots(a, b, c);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestPositiveDiscriminant_APositive_BPositive_CNegative()
        {
            float a = 2;
            float b = 5;
            float c = -3;
            float[] expected = { 0.5f, -3 };
            float[] result = MathHandler.FindRoots(a, b, c);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestPositiveDiscriminant_APositive_BPositive_CPositive()
        {
            float a = 1;
            float b = 4;
            float c = 3;
            float[] expected = { -1, -3 };
            float[] result = MathHandler.FindRoots(a, b, c);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestPositiveDiscriminant_APositive_BPositive_CZero()
        {
            float a = 1;
            float b = 2;
            float c = 0;
            float[] expected = { 0, -2 };
            float[] result = MathHandler.FindRoots(a, b, c);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestZeroDiscriminant_APositive_CPositive_BNegative()
        {
            float a = 1;
            float b = -2;
            float c = 1;
            float[] expected = { 1 };
            float[] result = MathHandler.FindRoots(a, b, c);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestZeroDiscriminant_APositive_BPositive_CPositive()
        {
            float a = 4;
            float b = 4;
            float c = 1;
            float[] expected = { -0.5f };
            float[] result = MathHandler.FindRoots(a, b, c);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestZeroDiscriminant_RootZero()
        {
            float a = 1;
            float b = 0;
            float c = 0;
            float[] expected = { 0 };
            float[] result = MathHandler.FindRoots(a, b, c);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNegativeDiscriminant_ANegative_BNegative_CNegative()
        {
            float a = -1;
            float b = -1;
            float c = -1;
            float[] expected = { };
            float[] result = MathHandler.FindRoots(a, b, c);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNegativeDiscriminant_APositive_BPositive_CPositive()
        {
            float a = 1;
            float b = 1;
            float c = 1;
            float[] expected = { };
            float[] result = MathHandler.FindRoots(a, b, c);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNegativeDiscriminant_APositive_BPositive_CPositive_Duplicate()
        {
            float a = 2;
            float b = 3;
            float c = 2;
            float[] expected = { };
            float[] result = MathHandler.FindRoots(a, b, c);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}