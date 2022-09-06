using System;
using System.Text;

namespace StringInvestigation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Investigation");

            string message = "this is a message";

            Console.WriteLine(message);

            int a = 10;
            int b = 20;

            int answer = a + b;

            message = "The answer is " + answer;

            Console.WriteLine(message);

            string s;
            String s2;

            s = new string("this is a string");


            message = String.Format("The answer is {0}", answer);

            Console.WriteLine(message);


            message = String.Format("{0} + {1} = {2}", a, b, answer);

            Console.WriteLine(message);


            double ans = (double)22 / 7;


            message = String.Format("{0:0.##}", ans);

            Console.WriteLine(message);



            // String.Format is built in to some functions:

            Console.WriteLine("the answer is {0:0.##}", ans);


            // escape characters


            message = "this \n is \n spread \n over \n multiple \n lines";
            Console.WriteLine(message);
            message = "press the \"red\" button";
            Console.WriteLine(message);

            string file = "C:\\my documents\\files\\test.txt";
            Console.WriteLine(file);


            // raw string

            file = @"c:\my documents\files\test.txt";

            Console.WriteLine(file);


            message = @"
                    raw strings
                    can span multiple
                    lines
                ";

            Console.WriteLine(message);


            // interpolated strings (f - strings )

            message = $"the answer is { answer }";

            Console.WriteLine(message);


            message = $"{ a } + { b } = { answer }";

            Console.WriteLine(message);


            message = $"{ a } + { b } = { a + b }";

            Console.WriteLine(message);


            string name = "Aidan";
            string city = "Cork";

            message = "My name is " + name + " I come from " + city;  // avoid concatenations

            message = String.Format("My name is {0} I come from {1}", name, city);

            message = $"My name is { name }, I come from { city }"; //<-- named substitutions are best

            Console.WriteLine(message);

            Random randomGenerator = new Random();

            int r = randomGenerator.Next(1, 100);

            if (r < 50)
            {
                message = $"{ r } is small";
            } else
            {
                message = $"{ r } is big";
            }

            Console.WriteLine(message);
            Console.WriteLine($"{ r } is { (r < 50 ? "small" : "big") }");


            // interpolated raw string
            message = @$"

            { a }
        +   { b }
==========================
            { a + b }
";
            Console.WriteLine(message);


            // beware of building strings through concatenation
            // because each opeation creates a brand new string object

            string[] lines =
            {
                "line 1",
                "line 2",
                "line 3",
                "line 4",
                "line 5",
            };

            string output = "";
            
            output = lines[0] + lines[1] + lines[2] + lines[3] + lines[4];

            for (int i=0; i<lines.Length; i++)
            {
                output += lines[i];
            }

            Console.WriteLine(output);

            // solution is to use StringBuilder

            Console.WriteLine("============================================");
            StringBuilder sb = new StringBuilder();

            for (int i=0; i<lines.Length; i++)
            {
                sb.Append(lines[i]);
            }

            Console.WriteLine(sb);














        }
    }
}
