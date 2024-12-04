using System;

namespace ZooPark
{
    internal class Eagle : Bird
    {
        public Eagle(string name, string diet, string location, double weight, int age, string colour, double wingspan, string birdSpecies)
        : base(name, diet, location, weight, age, colour, wingspan, birdSpecies)
        {
        }

        // Use 'new' to hide the base class fly method if intentional
        public new void fly()
        {
            Console.WriteLine("The eagle is now flying.");
        }

        // Use 'new' to hide the base class eat method if intentional
        public new void eat()
        {
            Console.WriteLine("I can Eat 15lbs of meat");
        }

        // Use 'new' to hide the base class sleep method if intentional
        public new void sleep()
        {
            Console.WriteLine("The eagle perches high on a tree branch and sleeps.");
        }
    }
}
