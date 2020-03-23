using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение линейного уравнения");
            Console.WriteLine("Введите коэффиценты a,b");
            double x = 0;
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());

            if (a != 0)
            {
                x = -b / a;
                Console.WriteLine($"Корень уравнения x = {x}");
            }
            else
            {
                if (b == 0)
                {
                    Console.WriteLine("Корень-любое число");
                }
                else
                    Console.WriteLine("Нет корней");
            }

            Console.ReadKey();
        }
    }
}
