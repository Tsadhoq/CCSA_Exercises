using System;
/* Define an abstract class Shape with abstract method CalculateSurface() and fields width and height. 
 * Define two additional classes for a triangle and a rectangle, which implement CalculateSurface(). 
 * This method has to return the areas of the rectangle (height*width) and the triangle (height*width/2). 
 * Define a class for a circle with an appropriate constructor, which initializes the two fields (height and width) 
 * with the same value (the radius) and implement the abstract method for calculating the area. Create an array of 
 * different shapes and calculate the area of each shape in another array.
 */

namespace ConsoleApp5
{
    abstract class Shape
    {
        public double Width = 10;
        public double Height = 13;

        public abstract double CalculateSurface();
    }

    class Triangle : Shape
    {
        public override double CalculateSurface()
        {
            return (Height * Width) / 2;
        }
    }

    class Rectangle : Shape
    {
        public override double CalculateSurface()
        {
            return (Height * Width);
        }
    }

    class Circle : Shape
    {
        public const double PI = 3.1415926535897931;

        public Circle(int radius)
        {
            this.Height = radius;
            this.Width = radius;
        }

        public override double CalculateSurface()
        {
            return PI * (Height * Width);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Triangle();
            shapes[1] = new Rectangle();
            shapes[2] = new Circle(5);

            double[] results = new double[] 
            {
                shapes[0].CalculateSurface(),
                shapes[1].CalculateSurface(),
                shapes[2].CalculateSurface()
            };

            foreach(double result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
