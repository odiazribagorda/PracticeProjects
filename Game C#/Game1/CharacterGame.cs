using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class CharacterGame
    {
        School School;
        Student Character;
        bool GoToMenu = false;

        public CharacterGame()
        {
            School = new School(true);
        }

        public Student GetCharacter()
        {
            return Character;
        }

        public void CreatCharacter()
        {
            Console.Clear();
            Console.Out.Write("Enter Character's Name: ");
            string name = Console.ReadLine();
            Console.Out.Write("Enter Character's Last Name: ");
            string lastName = Console.ReadLine();

            Character = new Student(name + " " + lastName);
            Console.WriteLine("Character created correctly...");
        }
        public void Start()
        {
            while (!GoToMenu)
            {
                PlayCharacterGame();
            }
            GoToMenu = false;
        }
        private void PlayCharacterGame()
        {
            ShowCharacterGameMenu();
            ExecuteCharacterGameOption();
        }
        private void ShowCharacterGameMenu()
        {
            Console.Clear();
            Console.WriteLine("Press the assigned key to choose an option");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("A - Show List of Students in School");
            if(!Character.GetInSchool()) Console.WriteLine("B - Start Going to School");
            Console.WriteLine("0 - Go back to MENU");
        }
        private void ExecuteCharacterGameOption()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.A: ShowListStudents(); break;
                case ConsoleKey.B: if(!Character.GetInSchool()) StartSchool();  break;
                case ConsoleKey.D0: GoToMenu = true; break;
                default: WrongCharacterGameOption(); break;
            }
        }

        private void StartSchool()
        {
            School.EnrollStudent(Character);
        }

        private void ShowListStudents()
        {
            Console.Clear();
            Console.WriteLine(School.ListStudentsConsole());
            Console.WriteLine("Press any key to go back...");
            Console.ReadKey(true);
        }

        private void WrongCharacterGameOption()
        {
            Console.Clear();
            Console.WriteLine("ERROR: Wrong game option\n");
            Console.WriteLine("Press any key to go back...");
            Console.ReadKey(true);
        }
    }
}
