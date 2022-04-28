using System;

namespace TriviaGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------Juego Trivia Samuel---------------------------");
            Game newGame = new Game();
            newGame.CreatePlayer();
            newGame.SetUpGame();
            newGame.Start();
            Console.ReadLine();
        }
    }
}
