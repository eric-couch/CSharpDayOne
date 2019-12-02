using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person Eric = new Person("Eric", 47, 'M');
            //Person Lindsey = new Person("Lindsey", 29, 'F');
            //Person Rain = new Person("Rain", 20, 'F');
            //Person Liya = new Person("Liya", 42, 'F');
            //Person Micheal = new Person("Micheal", 29, 'M');
            //Person Jarvis = new Person("Jarvis", 31, 'M');
            //Person Alexis = new Person("Alexis", 17, 'M');
            //Person Quay = new Person("Gequazion", 17, 'M');

            //var persons = new List<Person>();

            //persons.Add(Eric);
            //persons.Add(Lindsey);
            //persons.Add(Rain);
            //persons.Add(Liya);
            //persons.Add(Micheal);
            //persons.Add(Jarvis);
            //persons.Add(Alexis);
            //persons.Add(Quay);

            //foreach (Person p in persons)
            //{
            //    if (p.Age >= 18)
            //    {
            //        if (p.Gender == 'M')
            //        {
            //            Console.WriteLine(p.Name + " is eligible for the draft.");
            //        } else
            //        {
            //            Console.WriteLine(p.Name + " is not eligible for the draft because they are not Male.");
            //        }
            //    } else
            //    {
            //        Console.WriteLine(p.Name + " is not eligible for the draft because they are under age.");
            //    }
            //}

            // Six people, various ages and yearswithcommpany
            // write code to determine if they are eligible for retirement
            // age >= 60 and yearswithcompany >= 10
            // make some code to sort the list by name or age
            Employee Eric = new Employee("Eric Couch", 47, 2);
            Employee Gary = new Employee("Gary James", 65, 11);
            Employee Liya = new Employee("Liya", 41, 5);
            Employee Rain = new Employee("Rain", 20, 1);

            var employees = new List<Employee>();

            employees.Add(Gary);
            employees.Add(Liya);
            employees.Add(Rain);
            employees.Add(Eric);

            foreach (Employee e in employees)
            {
                if (e.Age >= 60)
                {
                    if (e.YearsWithCompany >= 10)
                    {
                        Console.WriteLine(e.Name + " is eligible for retirement.");
                    }
                    else
                    {
                        Console.WriteLine(e.Name + " needs " + (10 - e.YearsWithCompany) + 
                            "more years with the company to be eligible for retirement.");
                    }
                }
                else
                {
                    Console.WriteLine(e.Name + " needs to wait " + (60 - e.Age) + " more years to be eligible for retirement.");
                }
            }

            Console.WriteLine("***************** Before Sort *****************");

            foreach (Employee e in employees)
            {
                Console.WriteLine(e.ToString());
            }

            employees.Sort((a, b) => (a.Name.CompareTo(b.Name)));

            Console.WriteLine("***************** After Sort *****************");

            foreach (Employee e in employees)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
