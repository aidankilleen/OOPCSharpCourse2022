using System;
using System.Collections.Generic;
using System.Text;

namespace HrSystem
{
    class Tutor : Contractor, ITeacher
    {
        public Tutor(string firstName, string lastName, string agency) 
            : base(firstName, lastName, agency)
        {
        }
        public void Teach()
        {
            Console.WriteLine("Teach(): Sit down and listen, lesson starting");
        }

        public override void Display()
        {
            Console.WriteLine("Tutor:");
            base.Display();
        }
    }
}
