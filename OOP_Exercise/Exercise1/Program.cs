using System;
/* We are given a school.The school has classes of students.Each class has a set of teachers.
 * Each teacher teaches a set of courses. The students have a name and unique number in the class. 
 * Classes have a unique text identifier.Teachers have names. Courses have a name, count of classes and count of exercises.
 * The teachers as well as the students are people. Your task is to model the classes (in terms of OOP) along with their attributes 
 * and operations define the class hierarchy and create a class diagram with Visual Studio.
*/
namespace School
{
    class Teachers
    {
        public string TeacherName { get; set; }

    }

    class Students : Teachers
    {
        public string StudentName { get; set; }
        public int Id { get; set; }
    }


    class Courses : Teachers
    {
        public string CourseName { get; set; }
        public int CourseClass { get; set; }
        public int CourseExercises { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
