using System;

namespace AbstractExample.Models
{
    public class Duck : Animal
    {

        public Duck(string name)
        {
            Name = name;
        }

        public Duck()
        {
            Name = "Gerald";
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} says Quak Quak");
        }
    }
}