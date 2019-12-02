using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Dog
    {
        public String Breed { get; set; }
        public String Name { get; set; }
        public float Weight { get; set; }

        public String Bark()
        {
            return "woof";
        }

        public Dog(string breed, string name, float weight)
        {
            Breed = breed;
            Name = name;
            Weight = weight;
        }

        public override string ToString()
        {
            return String.Format("{0} is a {1} and weighs {2} lbs.", Name, Breed, Weight);
        }
    }
}
