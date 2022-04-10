using System;
/*Implement the following classes: Dog, Frog, Cat, Kitten and Tomcat. 
 * All of them are animals (Animal). Animals are characterized by age, name and gender. 
 * Each animal makes a sound (use a virtual method in the Animal class). Create an array of different 
 * animals and print on the console their name, age and the corresponding sound each one makes.
 */

namespace Exercise6
{
    class Animals
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public virtual string Sound()
        {
            return "Animal sound.";
        }
    }

    class Dog : Animals
    {
        public override string Sound()
        {
            return "Woof!";
        }
    }

    class Frog : Animals
    {
        public override string Sound()
        {
            return "Ribbit!";
        }
    }

    class Cat : Animals
    {
        public override string Sound()
        {
            return "Meow!";
        }
    }

    class Kitten : Animals
    {
        public override string Sound()
        {
            return "Meow!";
        }
    }

    class Tomcat : Animals
    {
        public override string Sound()
        {
            return "Meow!";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Array declaration
            var animals = new Animals[5];

            // First animal
            animals[0] = new Dog();
            animals[0].Name = "Bingo";
            animals[0].Age = 3;
            animals[0].Gender = "Male";

            // Second animal
            animals[1] = new Frog();
            animals[1].Name = "Beast";
            animals[1].Age = 1;
            animals[1].Gender = "Female";

            // Third animal
            animals[2] = new Kitten();
            animals[2].Name = "Beauty";
            animals[2].Age = 1;
            animals[2].Gender = "Male";

            // Fourth animal
            animals[3] = new Cat();
            animals[3].Name = "Sam";
            animals[3].Age = 3;
            animals[3].Gender = "Female";

            // Fifth animal
            animals[4] = new Tomcat();
            animals[4].Name = "Catty";
            animals[4].Age = 4;
            animals[4].Gender = "Male";

            for(int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine("\t{0} is {1} year(s) old and makes the sound '{2}'", animals[i].Name, animals[i].Age, animals[i].Sound());
            }
        }
    }
}
