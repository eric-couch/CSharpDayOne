using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Joker = new Dog("Malamute", "Joker", 110.0f);
            Console.WriteLine(Joker.ToString());
        }
    }
}
