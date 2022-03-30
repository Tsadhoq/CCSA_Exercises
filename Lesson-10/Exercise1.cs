using System;


namespace Lesson10Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Solve recursively the sum of all n number (n + n - 1 +....0)");
            Console.WriteLine("==========================");

            // Input the value
            Console.Write("Enter Number: ");
            int a = int.Parse(Console.ReadLine());

            // Call method
            int result = Sum(a);

            // Print result
            Console.WriteLine("Sum = " + result);
        }

        static int Sum(int num)
        {
            //int fac;
            if(num == 0)
            {
                return 0;
            }
            else
            {
                return num + Sum(num - 1);
            }
        }
    }
}
