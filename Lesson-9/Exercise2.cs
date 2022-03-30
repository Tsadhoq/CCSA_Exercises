using System;

namespace LessonTask2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("========================================");
            Console.WriteLine("CALCULATE THE FACTORIAL OF AN INTEGER (n)");
            Console.WriteLine("========================================");

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("========================================");
            Console.WriteLine(FactorialOfN(n));
        }

        static string FactorialOfN(int num)
        {
            int theNum = num;
            int fac = 1;
            while (num > 0)
            {
                fac = fac * num;
                num--;
            }

            return $"{theNum}! = {fac}";
        }
    }
}
