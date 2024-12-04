using System;

namespace ZooPark
{
    // Penguin class inherits from Bird class
    internal class Penguin : Bird
    {
        // Constructor to initialize the Penguin object
        public Penguin(String name, String diet, String location, double weight, int age, String colour, double Wingspan, String BirdSpecies)
        : base(name, diet, location, weight, age, colour, Wingspan, BirdSpecies)
        {

        }

        // Override method to show that penguins can't fly
        public override void fly()
        {
            Console.WriteLine("Penguin can't fly");
        }
    }
}
