using System;
using Humanizer;
// Installed an open-source and free NuGet package called Humanizer.Core

namespace LessonTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number to words conversion");
            Console.Write("Number: ");

            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Word: {NumberToWords(number)}");
        }

        static string NumberToWords(int num)
        {
            string word = num.ToWords();
            return word;
        }
    }
}
