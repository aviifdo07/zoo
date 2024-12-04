
using System;

namespace ZooPark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Your ZooPark initialization and execution code here
            Console.WriteLine("Welcome to ZooPark!");

            // Example: Create and display some animals
            Tiger tonyTiger = new Tiger("Tony", "Carnivore", "Africa", 220.5, 5, "Orange with Black Stripes", "Panthera tigris", "Black Stripes");
            tonyTiger.makeNoise();
            tonyTiger.eat();
            tonyTiger.sleep();

            Console.ReadKey();
        }
    }
}
