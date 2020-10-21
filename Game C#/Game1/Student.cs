using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Game
{
    public class Student
    {
        string Name;
        int Year;
        //Club Club;
        int Popularity;
        List<Student> Friends;
        bool InSchool;

        public Student()
        {
            Name = Names.GenerateFullName();
            Year = 0;
            Popularity = 0;
            Friends = new List<Student>();
            InSchool = false;
        }

        public Student(string name="", int year=0, int popularity=0, List<Student> friends=null, bool inSchool=false)
        {
            if (name == "") Name = Names.GenerateFullName();
            else Name = name;
            Year = year;
            Popularity = popularity;
            if (friends == null) Friends = new List<Student>();
            else Friends = friends;
            InSchool = inSchool;
        }

        public void AdvanceYear()
        {
            ++Year;
        }

        public void SetYear(int year)
        {
            Year = year;
        }

        public int GetYear()
        {
            return Year;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetInSchool(bool inSchool)
        {
            InSchool = inSchool;
        }

        public bool GetInSchool()
        {
            return InSchool;
        }

        public string ConsoleString()
        {
            string s = "Name: " + Name + "\n"
                + "Year: " + Year.ToString() + "\n"
                + "Popularity: " + Popularity.ToString() + "\n"
                + "Friends With: \n";
            return s;
        }
        
    }
}
