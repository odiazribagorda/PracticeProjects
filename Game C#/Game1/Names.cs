using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Game
{
    public static class Names
    {
        public static List<string> NameArray;
        public static List<string> LastNameArray;

        public static void LoadNames()
        {
            NameArray = new List<string>();
            foreach (string name in File.ReadAllLines(@"C:\Users\Óscar\Documents\Projects\Game1\Game1\Resources\Names.txt"))
            {
                NameArray.Add(name);
            }

            LastNameArray = new List<string>();
            foreach (string name in File.ReadAllLines(@"C:\Users\Óscar\Documents\Projects\Game1\Game1\Resources\LastNames.txt"))
            {
                LastNameArray.Add(name);
            }
        }


        public static string GenerateFullName()
        {
            return GenerateName() + " " + GenerateLastName();
        }

        public static string GenerateName()
        {
            Random random = new Random();
            return NameArray[random.Next(0, NameArray.Count-1)];
        }

        public static string GenerateLastName()
        {
            Random random = new Random();
            return LastNameArray[random.Next(0, NameArray.Count - 1)];
        }
    }
}
