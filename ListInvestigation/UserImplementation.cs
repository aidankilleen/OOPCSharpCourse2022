using System;
using System.Collections.Generic;
using System.Text;

namespace ListInvestigation
{
    public partial class User
    {
        public void Display()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name);
            Console.WriteLine(Email);
            Console.WriteLine(Active ? "Active" : "Inactive");
        }
    }
}
