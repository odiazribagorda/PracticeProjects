using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class School
    {
        public const int LAST_YEAR = 4;
        const int STUDENTS_PER_YEAR = 20;

        List<Student> Students;

        public School()
        {
            Students = new List<Student>();
        }

        public School(List<Student> students = null)
        {
            if (students == null) Students = new List<Student>();
            else
            {
                Students = new List<Student>();
                EnrollListOfStudents(students);
            }
        }

        public School(bool complete)
        {
            Students = new List<Student>();
            if(complete == true)
            {
                for (int i = 1; i < School.LAST_YEAR; ++i)
                {
                    EnrollListOfStudents(GenerateListOfStudents(STUDENTS_PER_YEAR));
                    NextYear();
                }
                EnrollListOfStudents(GenerateListOfStudents(STUDENTS_PER_YEAR));
            }
        }

        internal void NextYear()
        {
            List<Student> graduatingStudents = new List<Student>();
            foreach (Student student in Students)
            {
                if (student.GetYear() == LAST_YEAR) graduatingStudents.Add(student);
                else student.AdvanceYear();
            }
            if (graduatingStudents.Count > 0) Graduate(graduatingStudents);
        }

        public void Graduate(List<Student> students)
        {
            for (int i = 0; i < students.Count; ++i)
            {
                Students.Remove(students[i]);
            }
        }

        public void EnrollStudent(Student student)
        {
            Students.Add(student);
            student.SetYear(1);
            student.SetInSchool(true);
        }

        public void EnrollListOfStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                EnrollStudent(student);
            }
        }

        public string ListStudentsConsole()
        {
            int numSpace = 30;
            string s = "Student".PadRight(numSpace) + "Year\n"
                     + "----------------------------------------\n";
            for (int i = 0; i < Students.Count; ++i)
            {
                s += Students[i].GetName().PadRight(numSpace) + Students[i].GetYear().ToString() + "\n";
            }
            s += "----------------------------------------";

            return s;
        }

        public void ExpellStudent(Student student)
        {
            Students.Remove(student);
        }

        public static List<Student> GenerateListOfStudents(int numStudents)
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < numStudents; ++i)
            {
                Student student = new Student();
                students.Add(student);
            }
            return students;
        }
    }
}
