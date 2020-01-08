using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Info : PeopleDataProvider
    {
        public override void ReadFromConsole()
        {
            do
            {
                try
                {
                    Console.WriteLine("Введите имя");
                    Name = Console.ReadLine();
                    Console.WriteLine("Введите возраст");
                    Age = byte.Parse(Console.ReadLine());

                    break;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                }
            } while (true);
        }
        public override int AgeInYears(int numberOfYears)
        {
            return Age + numberOfYears;
        }

        public override string Description(int numberOfYears)
        {
            return $"Имя: {Name}, возраст через {numberOfYears} года будет {AgeInYears(numberOfYears)} ";
        }

        public override void Message(int numberOfYear = 4)
        {
            Console.WriteLine(Description(numberOfYear));
        }
    }
}
