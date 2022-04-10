using System;
using System.Collections.Generic;
//Initialize an array of 10 students and sort them by mark in ascending order.Use the interface System.IComparable<T>.

namespace ConsoleApp3
{
    class Student : IComparable
    {
        // Fields
        public int Score;
        public string Name;

        // Student constructor
        public Student(int num, string name)
        {
            this.Name = name;
            this.Score = num;
        }

        public int CompareTo(object incomingobject)
        {
            Student incomingstudent = incomingobject as Student;
            return this.Score.CompareTo(incomingstudent.Score);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
                {
                new Student(23, "Sanni"),
                new Student(46, "John"),
                new Student(34, "Sam"),
                new Student(21, "Murphy"),
                new Student(68, "Dan"),
                new Student(79, "Pam"),
                new Student(11, "Sham"),
                new Student(43, "Pat"),
                new Student(80, "Chris"),
                new Student(100, "Edem")
                };


            // Displaying the student's array before sorting
            Console.WriteLine("Before sorting student array");
            foreach (var stu in students)
            {
                Console.WriteLine("Score - {0}\t|\tStudent Name - {1}", stu.Score, stu.Name);
            }

            // Sorts the students array in ascending  order on basis of score of the student
            Array.Sort(students);
            Array.Reverse(students);

            Console.WriteLine();

            // Printing the student's array after sorting
            Console.WriteLine("After sorting student array");
            foreach (var stu in students)
            {
                Console.WriteLine("Score - {0}\t|\tStudent Name - {1}", stu.Score, stu.Name);
            }
        }

    }
}
