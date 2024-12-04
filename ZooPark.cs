using System;

namespace ZooPark
{
    // Main class to create and test animal objects
    internal class ZooPark
    {
        static void Main(string[] args)
        {
            // Creating animal objects and testing methods
            Animal animal = new Animal("Generic Animal", "Herbivore", "Africa", 150, 5, "Grey");
            Tiger tonyTiger = new Tiger("Tony", "Carnivore", "Jungle", 250, 7, "Orange", "Tiger", "Black Stripes");
            Eagle eagleEye = new Eagle("EagleEye", "Carnivore", "Mountains", 15, 3, "Brown", 2.5, "Eagle");
            Penguin pengu = new Penguin("Pengu", "Carnivore", "Antarctica", 35, 10, "Black & White", 1.2, "Penguin");

            // Testing the methods
            animal.eat();
            animal.sleep();
            animal.makeNoise();

            tonyTiger.eat();
            tonyTiger.sleep();
            tonyTiger.makeNoise();

            eagleEye.fly();
            eagleEye.eat();
            eagleEye.sleep();

            pengu.fly();
            pengu.layEgg();

            Console.ReadKey();
        }
    }
}
