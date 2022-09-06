using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayInvestigation
{
    class CollectionInvestigation
    {
        static void Main(string[] args)
        {

            ArrayList al = new ArrayList();

            al.Add("one");
            al.Add("two");
            al.Add("three");
            // al.Add(999);

            // we don't use ArrayList any more 
            // because it is missing type safety

            foreach (string item in al)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
