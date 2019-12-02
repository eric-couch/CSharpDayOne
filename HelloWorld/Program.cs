using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Eric = new Person("Eric", 47, 'M');
            Person Lindsey = new Person("Lindsey", 29, 'F');
            Person Rain = new Person("Rain", 20, 'F');
            Person Liya = new Person("Liya", 42, 'F');
            Person Micheal = new Person("Micheal", 29, 'M');
            Person Jarvis = new Person("Jarvis", 31, 'M');
            Person Alexis = new Person("Alexis", 17, 'M');
            Person Quay = new Person("Gequazion", 17, 'M');

            var persons = new List<Person>();

            persons.Add(Eric);
            persons.Add(Lindsey);
            persons.Add(Rain);
            persons.Add(Liya);
            persons.Add(Micheal);
            persons.Add(Jarvis);
            persons.Add(Alexis);
            persons.Add(Quay);
            
            foreach (Person p in persons)
            {
                if (p.Age >= 18)
                {
                    if (p.Gender == 'M')
                    {
                        Console.WriteLine(p.Name + " is eligible for the draft.");
                    } else
                    {
                        Console.WriteLine(p.Name + " is not eligible for the draft because they are not Male.");
                    }
                } else
                {
                    Console.WriteLine(p.Name + " is not eligible for the draft because they are under age.");
                }
            }

        }
    }
}
