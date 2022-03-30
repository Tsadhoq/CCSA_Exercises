using System;

namespace LessonTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("NUMBER OF STRING CHARACTERS IN YOUR INPUT");
            Console.WriteLine("=========================================");

            Console.Write("Type your string: ");
            string n = Console.ReadLine();

            Console.WriteLine("=========================================");
            Console.WriteLine(StringCharCount(n));
        }

        static string StringCharCount(string word)
        {
            char[] charArray = word.ToCharArray();
            int lenWord = charArray.Length;
            return $"Number of characters in the string = {lenWord}";
        }
    }
}
