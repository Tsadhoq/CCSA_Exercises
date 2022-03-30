using System;


namespace Lesson10Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type the number you want to find: ");
            int n = Convert.ToInt32(Console.ReadLine());
            var watch = System.Diagnostics.Stopwatch.StartNew();


            int count = 1;
            if ((n < 0) || (n > 20))
            {
                Console.WriteLine("Invalid entry");
            }
            else
            {
                RandomThings(n, count);
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"{n} Found at Execution Time: {elapsedMs} ms");
        }

        static void RandomThings(int num, int i)
        {
            Random r = new Random();
            int rInt = r.Next(0, 100);

            if (rInt == num)
            {
                return;
            }
            Console.WriteLine(rInt + $" is iteration {i}");
            RandomThings(num, i + 1);

          
        }
    }
}
