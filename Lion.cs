using System;

namespace ZooPark
{
    internal class Lion : Feline
    {

        private String colourStripes;

        public Lion(String name, String diet, String location, double weight, int age, String colour, String species, String colourStripes)
            : base(name, diet, location, weight, age, colour, species)
        {
            this.colourStripes = colourStripes;
        }

    }
}
