using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    // Base class for all animals in the zoo
    public class Animal
    {
        private String name;
        private String diet;
        private String location;
        private double weight;
        private int age;
        private String colour;

        // Constructor to initialize the Animal object

        public Animal(String name, String diet, String location, double weight, int age, String colour)
        {
            this.name = name;
            this.diet = diet;
            this.location = location;
            this.weight = weight;
            this.age = age;
            this.colour = colour;
        }

        // Method for the animal to eat

        public void eat()
        {
            Console.WriteLine("This animals eats");

        }

        // Method for the animal to sleep

        public void sleep()
        {
            Console.WriteLine("This animals sleeps");

        }

        // Method for the animal to make a noise
        public void makeNoise()
        {
            Console.WriteLine("The noise these animal does");

        }

        public void makeLionNoise()
        {

            Console.WriteLine("Roarrrr!");
        }

        public void makeEagleNoise()
        {
            Console.WriteLine("Screech!");
        }

        public void makeWolfNoise()
        {
            Console.WriteLine("Awooooooo!");
        }

        public void eatMeat()
        {
            Console.WriteLine("Eating meat");
        }

        public void eatBerries()
        {
            Console.WriteLine("Eating berries");
        }
    }
}
