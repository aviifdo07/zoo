using System;

namespace ZooPark
{
    // Bird class inherits from Animal class
    internal class Bird : Animal
    {

        public double Wingspan;
        public String BirdSpecies;

        // Constructor to initialize the Bird object
        public Bird(String name, String diet, String location, double weight, int age, String colour, double Wingspan, String BirdSpecies)
        : base(name, diet, location, weight, age, colour)
        {
            this.Wingspan = Wingspan;
            this.BirdSpecies = BirdSpecies;
        }

        // Method for the bird to lay an egg
        public virtual void layEgg()
        {
            Console.WriteLine("An egg has been laid.");
        }

        // Method for the bird to fly
        public virtual void fly()
        {
            Console.WriteLine("The bird is now flying.");
        }
    }
}
