using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public abstract class PeopleDataProvider : Person
    {
        public abstract void ReadFromConsole();

        public abstract int AgeInYears(int numberOfYears);

        public abstract string Description(int numberOfYears);

        public abstract void Message(int numberOfYear = 4);
    }
}
