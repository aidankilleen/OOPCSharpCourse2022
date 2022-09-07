using System;
using System.Collections.Generic;
using System.Text;

namespace ListInvestigation
{
    class ParamterInvestigation
    {

        public static void SomeFunction(string name="John", string county="Dublin", int age=21)
        {
            Console.WriteLine($"{ name } - { county } - { age }");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Parameter Investigation");

            SomeFunction("Aidan", "Cork", 21);
            SomeFunction(age: 99, name: "Fred", county: "Dublin");
            SomeFunction("Alice", "Waterford");
            SomeFunction("Bob");
            SomeFunction();

            SomeFunction(age: 99);
            SomeFunction(name: "Carol");
            SomeFunction(county: "Donegal");






        }

    }
}
