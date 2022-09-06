using System;
using System.Collections.Generic;
using System.Text;

namespace HrSystem
{
    class PolymorphismTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polymorphism Test");

            Person[] team = new Person[]
            {
                new Person("Alice", "Adams"), 
                new Employee("Bob", "Burns", "E12345"), 
                new Contractor("Carol", "Conway", "CPL"), 
                new Manager("Danielle", "Daly", "E1111", 15)
            };

            for (int i=0; i<team.Length; i++)
            {
                team[i].Display();
            }

        }
    }
}
