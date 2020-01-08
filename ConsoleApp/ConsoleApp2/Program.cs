using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Info[3];

            for (int i = 0; i < person.Length; i++)
            {
                person[i] = new Info();
                person[i].ReadFromConsole();
            }

            for (int i = 0; i < person.Length; i++)
            {
                person[i].Message();
            }
        }
    }
}



