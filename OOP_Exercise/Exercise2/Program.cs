using System;
/*Define a class Human with properties "first name" and "last name". 
 * Define the class Student inheriting Human, which has the property "mark". 
 * Define the class Worker inheriting Human with the property "wage" and "hours worked". 
 * Implement a "calculate hourly wage" method, which calculates a worker's hourly pay rate based on wage and hours worked.
 * Write the corresponding constructors and encapsulate all data in properties.
*/
namespace ConsoleApp2
{
    // Human class
    class Human
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
    }
    // Student class
    class Student : Human
    {

    }
    // Worker class
    class Worker : Human
    {
        private string Wage { get; set; }
        private string Hoursworked { get; set; }

        // Method
        public double CalculateHourlyWage(double wage, double hours)
        {
            double hourlyWage = wage / hours;
            return hourlyWage;
        }
    }
    // Main class
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
