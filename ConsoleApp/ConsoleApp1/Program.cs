using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pet1 = new Pet();
            pet1.Name = "Мурзик";
            pet1.Age = 5;
            pet1.Kind = Pet.Animals.Cat;
            pet1.Gender = 'm';
            pet1.BirthPlace("Сочи");
            Console.WriteLine(pet1.Description);

            var pet2 = new Pet()
            {
                Name = "Milly",
                Age = 17,
                Kind = Pet.Animals.Dog,
                Gender = 'f'
            };
            pet2.BirthPlace("Москва");
            Console.WriteLine(pet2.Description);

            Console.ReadKey();
        }
    }
    class Pet
    {
        private string _birthPlace;
        private char _gender;
        public enum Animals
        {
            Cat,
            Dog
        };

        public string Name { get; set; }
        public int Age { get; set; }

        public Animals Kind;
        public char Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                if (char.ToLowerInvariant(value).Equals('f') || char.ToLowerInvariant(value).Equals('m'))
                {
                    _gender = char.ToUpperInvariant(value);
                }
                else
                {
                    throw new Exception("Wrong data");
                }
            }
        }

        public void BirthPlace(string city)
        {
            _birthPlace = city;
        }

        public string Description
        {
            get
            {
                return $"Имя: {Name}, возраст: {Age}, животное {Kind}, пол {Gender}, место обитания {_birthPlace}.";
            }
        }

    }
}
