using System;

namespace Lesson11Task2
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


        static int StringCharCount(string word)
        { 
            if(word.Equals(""))
            {
                return 0;
            }
            else
            {
                return StringCharCount(word.Substring(1)) + 1;
            }
        }
    }
}
