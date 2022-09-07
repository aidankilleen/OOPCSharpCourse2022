using System;
using System.Collections.Generic;
using System.Text;

namespace ListInvestigation
{
    class TupleInvestigation
    {

        static (int Total, double Average) DoCalculations(List<int> list)
        {
            int total = 0;
            list.ForEach(item => total += item);
            double avg = (double)total / list.Count;
            return (Total:total, Average:avg);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Tuple Investigation");

            List<int> list = new List<int>
            {
                1, 4, 3, 7, 5, 9, 10, 2
            };
            
            (int Total, double Average) answer = DoCalculations(list);
            Console.WriteLine($"The answer is { answer.Total }  { answer.Average } ");

            //(int, int, int, int) t = (1, 2, 3, 4);


            int a = 100;

            int b = 10;
            Console.WriteLine($"{ a } { b }");

            (a, b) = (b, a);

            Console.WriteLine($"{ a } { b }");

        }
    }
}
