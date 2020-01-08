using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3_GuessTheNumber
{
    public enum GuessingPlayer
    {
        Human,
        Machine
    }
    public class GuessNumberGame
    {
        private readonly int _max;
        private readonly int _maxCount;
        private readonly GuessingPlayer _guessingPlayer;
        int count;
        int input;
        int guesseddNumber;

        public GuessNumberGame(int max = 50, int maxTries = 5, GuessingPlayer guessingPlayer = GuessingPlayer.Human)
        {
            _max = max;
            _maxCount = maxTries;
            _guessingPlayer = guessingPlayer;
        }

        public void Start()
        {
            if (_guessingPlayer == GuessingPlayer.Human)
            {
                HumanGuesses();
            }
            else
            {
                MachineGuesses();
            }
        }
        private void HumanGuesses()
        {
            var random = new Random();
            guesseddNumber = random.Next(0, _max);

            Console.WriteLine("Угадайте число!");
            while (input != guesseddNumber && count < _maxCount)
            {
                input = int.Parse(Console.ReadLine());

                if (input == guesseddNumber)
                {
                    Console.WriteLine("Поздравляю! Вы угадали число");
                    break;
                }
                else if (input > guesseddNumber)
                {
                    Console.WriteLine("Вы задали слишком большое число");
                }
                else
                {
                    Console.WriteLine("Вы задали слишком маленькое число");
                }

                count++;
                if (count == _maxCount)
                {
                    Console.WriteLine("Вы проиграли :(");
                }
            }
        }

        private void MachineGuesses()
        {
            Console.WriteLine("Введите число, которое будет угадываться компьютером");
            input = int.Parse(Console.ReadLine());
            int min = 0;
            int max = _max;

            while (guesseddNumber != input && count < _maxCount)
            {
                guesseddNumber = (min + max) / 2;
                Console.WriteLine($"Ваше загаданное число - {guesseddNumber}?");
                Console.WriteLine("Если да, то нажмите 'да', если число больше - нажмите '+', если меньше - '-' ");

                string answer = Console.ReadLine();
                if (answer == "да")
                {
                    Console.WriteLine("Супер! Программа отгадала число");
                    break;
                }
                else if (answer == "+")
                {
                    min = guesseddNumber;
                }
                else
                {
                    max = guesseddNumber;
                }

                if (guesseddNumber == input)
                {
                    Console.WriteLine("Кто-то решил меня перехитрить");
                }
                count++;
                if (count == _maxCount)
                {
                    Console.WriteLine("Я сдаюсь :( ");
                }
            }
        }
    }
}
