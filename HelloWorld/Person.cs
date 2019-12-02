using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public Char Gender { get; set; }

        public Person(string name, int age, char gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
}
