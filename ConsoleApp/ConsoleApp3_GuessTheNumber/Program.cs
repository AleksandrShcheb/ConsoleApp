using System;

namespace ConsoleApp3_GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new GuessNumberGame(guessingPlayer: GuessingPlayer.Machine);
            game.Start();
        }
    }
}
