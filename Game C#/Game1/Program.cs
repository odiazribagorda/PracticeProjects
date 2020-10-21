using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting game...");
            Names.LoadNames();
            Game Game = new Game();
            Game.GameStart();

            Console.WriteLine("Press ENTER to Exit...");
            Console.ReadKey();
        }
    }
}
