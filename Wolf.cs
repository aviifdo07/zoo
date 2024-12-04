using System;

namespace ZooPark
{
    internal class Wolf : Animal
    {
        public Wolf(string name, string diet, string location, double weight, int age, string colour)
        : base(name, diet, location, weight, age, colour)
        {
        }

        // Use 'new' to hide the base class makeNoise method if intentional
        public new void makeNoise()
        {
            Console.WriteLine("Howl");
        }

        // Use 'new' to hide the base class eat method if intentional
        public new void eat()
        {
            Console.WriteLine("I can Eat 10lbs of meat");
        }

        // Use 'new' to hide the base class sleep method if intentional
        public new void sleep()
        {
            Console.WriteLine("The wolf finds a den and sleeps soundly.");
        }
    }
}
