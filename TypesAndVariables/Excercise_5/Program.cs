using System;
using System.Runtime.Intrinsics.Arm;

namespace Excercise_5
{
    class Program
    {
        static readonly string[] Lessons = new string[]
            {"Principles of Technology I", "Precalculus", "English III", "AP US History", "Latin II"};

        static readonly string[] Teachers = new string[]
            {"Mr. Davis", "Ms. Palmer", "Mrs. Barnett", "Ms. Lapan", "Ms. Johannessenburgen II"};


        static void Main(string[] args)
        {
            string longestWordInLessons = Lessons[0];
            string longestWordInTeachers = Teachers[0];

            foreach (var t in Lessons)
            {
                if (t.Length > longestWordInLessons.Length) longestWordInLessons = t;
            }

            foreach (var t in Teachers)
            {
                if (t.Length > longestWordInTeachers.Length) longestWordInTeachers = t;
            }

            int outputFrameWidth = longestWordInTeachers.Length + longestWordInLessons.Length + 6;
            for (int i = 0; i <= outputFrameWidth; i++)
            {
                if (i == 0)
                {
                    Console.Write("#");
                }

                Console.Write("=");

                if (i == outputFrameWidth)
                {
                    Console.WriteLine("#");
                }
            }

            for (int j = 0; j < Lessons.Length; j++)
            {
                var spacesInLessonsColumn = new String(' ', longestWordInLessons.Length - Lessons[j].Length);
                var spacesInTeachersColumn = new String(' ', longestWordInTeachers.Length - Teachers[j].Length);
                Console.WriteLine(
                    $"| {j} |{Lessons[j]}{spacesInLessonsColumn} | {Teachers[j]}{spacesInTeachersColumn}|");
            }

            for (int i = 0; i <= outputFrameWidth; i++)
            {
                if (i == 0)
                {
                    Console.Write("#");
                }

                Console.Write("=");

                if (i == outputFrameWidth)
                {
                    Console.WriteLine("#");
                }
            }
        }
    }
}