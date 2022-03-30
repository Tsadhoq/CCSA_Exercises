using System;

namespace LessonTask1
{
    class Program
    {
        static void Main(string[] args)
        {
  
            Console.WriteLine("==========================");
            Console.WriteLine("SOLVE A QUADRATIC EQUATION (ax² + bx + c = 0)");
            Console.WriteLine("==========================");

            // Input the value of a, b and c
            Console.Write("Enter the value of a: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Enter the value of b: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Enter the value of c: ");
            float c = float.Parse(Console.ReadLine());

            // Call the method and display the result
            Console.WriteLine(QuadraticRoot(a, b, c)); 

        }

        static string QuadraticRoot(float num1, float num2, float num3)
        {

            // Quadratic formula
            double calc = Math.Pow(num2, 2) - (4 * num1 * num3);

            if (calc < 0)
            {
                return "No real solutions.";
            }

            double numerator1 = -num2 + Math.Sqrt(calc);
            double numerator2 = -num2 - Math.Sqrt(calc);
            double denominator = 2 * num1;

            double root1 = numerator1 / denominator;
            double root2 = numerator2 / denominator;

            string result = $"x = {root1} or {root2}";

            // Return the result
            return result;
        }
    }
}
