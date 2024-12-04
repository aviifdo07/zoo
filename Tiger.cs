using System;

namespace ZooPark
{
    internal class Tiger : Feline
    {
        private string colourStripes;

        public Tiger(string name, string diet, string location, double weight, int age, string colour, string species, string colourStripes)
        : base(name, diet, location, weight, age, colour, species)
        {
            this.colourStripes = colourStripes;
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
            Console.WriteLine("The tiger finds a quiet spot and sleeps.");
        }
    }
}
