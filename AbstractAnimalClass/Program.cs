using System;
using System.Xml.Linq;

namespace Animals
{
    abstract class Animal
    {
        // Property
        public abstract string Name { get; set; }
       
        public abstract int Age { get; set; }

        public abstract int Length { get; set; }
        // Methods
        public abstract string Describe();

        public abstract string AgeLength();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }

    class Program
    {
        class Fish : Animal
        {
            // override the abstract property
            public override string Name { get; set; }
            public override int Age { get; set; }
            public override int Length { get; set; }

            public string Type { get; set; }

            public Fish()
            {
                Name = string.Empty;
                Type = string.Empty;
                Age = 0;
                Length = 0;
            }
            public Fish(string name, string type, int age, int length)
            {
                Name = name;
                Type = type;
                Age = age;
                    
                Length = length;
            }
            // override the abstract method
            public override string Describe()
            {
                return "I am a " + Type + "\nMy name is " + Name;
            }
            public override string AgeLength()
            {
                return "I am " + Age + " years old & I am " + Length + " inches long.";
            }
        }
        static void Main(string[] args)
        {
            Fish goldie = new Fish("Goldie","Goldfish",3,14);
            Console.WriteLine(goldie.whatAmI());
            Console.WriteLine(goldie.Describe());
            Console.WriteLine(goldie.AgeLength());
            Console.WriteLine("");

            // Create Fish object 
            Fish boogie = new Fish();
            boogie.Name = "Boogie";
            boogie.Type = "Oscar Fish";
            boogie.Age = 2;
            boogie.Length = 12;
            Console.WriteLine(boogie.whatAmI());
            Console.WriteLine(boogie.Describe());
            Console.WriteLine(boogie.AgeLength());
        }
    }
}
