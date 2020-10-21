using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class Game
    {
        bool GameIsFinished = false;
        List<CharacterGame> CharacterGames;

        public Game()
        {
            CharacterGames = new List<CharacterGame>();
        }

        public void GameStart()
        {
            ShowGameStart();
            while (!GameIsFinished)
            {
                PlayGame();
            }
        }
        private void ShowGameStart()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Competitive Friendship HS");
            Console.WriteLine("====================================");
        }
        private void PlayGame()
        {
            ShowGameMenu();
            ExecuteGameOption();
        }
        private void ShowGameMenu()
        {
            Console.Clear();
            Console.WriteLine("Press the assigned key to choose an option");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("A - Create a new Character");
            Console.WriteLine("B - Your Characters");
            Console.WriteLine("0 - EXIT Game");
        }
        private void ExecuteGameOption()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.A: CreateNewCharacter(); break;
                case ConsoleKey.B: PlayWithCreatedCharacter(); break;
                case ConsoleKey.D0: GameIsFinished = true; break;
                default: WrongGameOption(); break;
            }
        }

        private void PlayWithCreatedCharacter()
        {
            CharacterGame characterGame = ChooseCharacter();
            characterGame?.Start();
        }

        private CharacterGame ChooseCharacter()
        {
            Console.Clear();
            if (CharacterGames.Count > 0)
            {
                bool stop = false;
                while (!stop)
                {
                    Console.WriteLine("Choose character:");
                    int i = 0;
                    foreach (CharacterGame characterGame in CharacterGames)
                    {
                        Console.Out.Write((char)('A' + (i++)));
                        Console.WriteLine(" - " + characterGame.GetCharacter().GetName());
                    }
                    Console.WriteLine("0 - Go BACK");

                    ConsoleKeyInfo info = Console.ReadKey();
                    Console.WriteLine("You've chosen " + info.KeyChar);
                    if (info.KeyChar >= 'a' && info.KeyChar - 'a' < CharacterGames.Count)
                        return CharacterGames[info.KeyChar - 'a'];
                    else if (info.Key == ConsoleKey.D0)
                        stop = true;
                    else
                    {
                        Console.WriteLine("Wrong option!!");
                    }
                }
            }
            else
            {
                Console.WriteLine("There´s no available characters");
                Console.WriteLine("Press any key to go back...");
                Console.ReadKey(true);
            }
            return null;
        }

        private void CreateNewCharacter()
        {
            CharacterGame characterGame = new CharacterGame();
            characterGame.CreatCharacter();
            CharacterGames.Add(characterGame);
            characterGame.Start();
        }

        private void WrongGameOption()
        {
            Console.Clear();
            Console.WriteLine("ERROR: Wrong game option");
            Console.WriteLine("Press any key to go back...");
            Console.ReadKey(true);
        }

    }
}
