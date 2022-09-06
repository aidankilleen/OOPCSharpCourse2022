using System;
using System.Collections.Generic;
using System.Text;

namespace HrSystem
{
    class PersonListInvestigation
    {

        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            people.Add(new Person("Alice", "Adams"));
            people.Add(new Employee("Bob", "Burns", "E11111"));
            people.Add(new Contractor("Carol", "Conway", "CPL"));
            people.Add(new Manager("Danielle", "Dunne", "E22222", 15));

            foreach(Person p in people)
            {
                p.Display();
            }
        }
    }
}
