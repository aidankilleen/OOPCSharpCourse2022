using System;
using System.Collections.Generic;
using System.Text;

namespace HrSystem
{
    class InterfaceInvestigation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface Investigation");


            Trainer trainer = new Trainer("Eve", "Evans", "E121212");
            trainer.Display();
            //trainer.Teach();

            Tutor tutor = new Tutor("Fred", "Finn", "CPL");
            tutor.Display();
            //tutor.Teach();


            // the real test is can I use Trainer and Tutor polymorphically????
            // i.e. can I create a heterogeneous list of Teachers

            ITeacher[] teachers = new ITeacher[] {
                  new Trainer("Eve", "Evans", "E12121212"),
                  new Tutor("Fred", "Finn", "CPL")
            };

            for (int i=0; i<teachers.Length; i++) {

                teachers[i].Teach();
            }
        }
    }
}
