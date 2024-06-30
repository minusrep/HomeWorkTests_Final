using System;
using System.Diagnostics;
namespace HomeWork1of2
{
    public class MathHandler
    {
        public static float[] FindRoots(float a, float b, float c)
        {
            var discriminant = b * b - 4f * a * c;
            float[] roots;
            if (discriminant > 0f)
            {
                roots = new float[2];
                roots[0] = (float)(-b + Math.Sqrt(discriminant)) / (2f * a);
                roots[1] = (float)(-b - Math.Sqrt(discriminant)) / (2f * a);
            }
            else if (discriminant == 0f)
            {
                roots = new float[1];
                roots[0] = -b / (2f * a);
            }
            else
                roots = new float[0];
            return roots;
        }
        public static float TriangleArea(float a, float b, float c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException();
            float s = (a + b + c) / 2f;
            float area = (float)Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
        public static float GetFahrenheit(float celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static float GetCelsius(float fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static float Average(float[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("The array is empty");
            var total = 0f;
            var count = 0;
            foreach (var number in numbers)
            {
                total += number;
                count++;
            }
            return total / count;
        }

        public static int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Negative values are not allowed", nameof(n));
            }

            if (n > 12) throw new OverflowException();

            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
