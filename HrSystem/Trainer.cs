using System;
using System.Collections.Generic;
using System.Text;

namespace HrSystem
{
    class Trainer : Employee, ITeacher
    {
        public Trainer(string firstName, string lastName, string employeeId)
            :base(firstName, lastName, employeeId)
        {
        }
        public void Teach()
        {
            Console.WriteLine("Settle down, lesson is starting");
        }
        public override void Display()
        {
            Console.WriteLine("Trainer:");
            base.Display();
        }
    }
}
