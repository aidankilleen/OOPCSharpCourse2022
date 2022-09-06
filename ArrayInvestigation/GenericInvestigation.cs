using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayInvestigation
{
    class GenericInvestigation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic Investigation");

            List<string> list = new List<string>();

            list.Add("one");
            list.Add("two");
            list.Add("three");
            //list.Add(999);     type safety is built in.

            foreach(string item in list)
            {
                Console.WriteLine(item);
            }
            List<int> numbers = new List<int>();

            numbers.Add(1);
            //numbers.Add("one");

            Console.WriteLine("=============================");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "one");
            dictionary.Add(2, "two");
            dictionary.Add(3, "three");
            dictionary.Add(4, "four");


            //Console.WriteLine(dictionary[999]);



            Dictionary<string, int> countyLookup = new Dictionary<string, int>();

            countyLookup.Add("Cork", 200000);
            countyLookup.Add("Dublin", 1200000);
            countyLookup.Add("Limerick", 190000);
            countyLookup.Add("Kerry", 120000);

            //countyLookup.Add(1, "Waterford");

            Console.WriteLine(countyLookup["Dublin"]);




        }
    }
}
