using System;

namespace ZooPark
{
    internal class Feline : Animal
    {
        private string species;

        // Constructor to initialize the Feline object
        public Feline(string name, string diet, string location, double weight, int age, string colour, string species)
        : base(name, diet, location, weight, age, colour)
        {
            this.species = species;
        }

        // Use 'new' to hide the base class makeNoise method if intentional
        public new void makeNoise()
        {
            Console.WriteLine("ROARRRRRRRRRRR");
        }

        // Use 'new' to hide the base class eat method if intentional
        public new void eat()
        {
            Console.WriteLine("I can Eat 20lbs of meat");
        }

        // Use 'new' to hide the base class sleep method if intentional
        public new void sleep()
        {
            Console.WriteLine("The feline curls up and sleeps comfortably.");
        }
    }
}
