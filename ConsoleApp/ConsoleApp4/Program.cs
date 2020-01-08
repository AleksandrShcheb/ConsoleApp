using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Sum(2.5 , 2.5));

            //Console.WriteLine(Calculator.Averange(new double[] { 1,2,3})); без params

            Console.WriteLine(Calculator.Averange(1, 2, 3));
        }
    }
}
