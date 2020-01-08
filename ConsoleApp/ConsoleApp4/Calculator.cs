using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public static class Calculator
    {
        public static int Sum (int a, int b)
        {
            return a + b;
        }

        public static double Sum (double a, double b)
        {
            return a + b;
        }

        public static double Averange(params double[] numbers)
        {
            double result = 0;
            foreach (var item in numbers)
            {
                result += item;
            }
            return result / numbers.Length;
        }
    }
}
