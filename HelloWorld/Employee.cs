using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Employee
    {
        public String Name { get; set; }
        public int Age { get; set; }

        public int YearsWithCompany { get; set; }

        public Employee(string name, int age, int yearsWithCompany)
        {
            Name = name;
            Age = age;
            YearsWithCompany = yearsWithCompany;
        }

        public override string ToString()
        {
            return "Name: " + this.Name + "\n" + "Age: " + this.Age + "\n" + "YearsWithCompany: " + this.YearsWithCompany;
        }
    }
}
