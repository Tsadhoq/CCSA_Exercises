using System;


namespace Lesson10Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print all Prime numbers for a specified range of values using recursion
            Console.WriteLine("=========================================");
            Console.WriteLine("FIND PRIME NUMBERS FROM A TO B (A ≥ 2)");
            Console.WriteLine("=========================================");

            Console.Write("ENTER A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("ENTER B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("=========================================");
            for (int i = a; i <= b; i++)
            {
                if (PrimeNumbers(2, i) == 0)
                {
                    Console.WriteLine("{0} ", i);
                }
            }

        }

        static int PrimeNumbers(int num1, int num2)
        {
            if (num1 == num2)
            {
                return 0;
            }
            else if (num2 % num1 == 0)
            {
                return 1;
            }
            else
            {
                return PrimeNumbers(num1 + 1, num2);
            }
        }
    }
}
