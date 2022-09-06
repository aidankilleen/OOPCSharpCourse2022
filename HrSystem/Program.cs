using System;

namespace HrSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HR System");
            Person p = new Person("Alice", "Adams");
            p.Display();

            Employee e = new Employee("Bob", "Burns", "E12345");
            e.Display();

            Contractor c = new Contractor("Carol", "Conway", "CPL");
            c.Display();

            Manager m = new Manager("Danielle", "Daly", "E54333", 10);
            m.Display();

        }
    }
}
