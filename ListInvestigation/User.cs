using System;
using System.Collections.Generic;
using System.Text;

namespace ListInvestigation
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }

        public void Display()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name);
            Console.WriteLine(Email);
            Console.WriteLine(Active ? "Active" : "Inactive");
        }
    }
}
