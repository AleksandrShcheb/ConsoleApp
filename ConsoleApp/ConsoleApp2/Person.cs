using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Person
    {
        private string _name;
        private int _age;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                    throw new Exception("Введено неккоректное имя");
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0 && value < 150)
                {
                    _age = value;
                }
                else
                    throw new Exception("Введен неккоректный возраст");
            }
        }
    }
}