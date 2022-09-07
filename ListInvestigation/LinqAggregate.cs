using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ListInvestigation
{
    class LinqAggregate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linq Aggregate");

            List<(int Id, string Name, double Quantity)> data = new List<(int, string, double)>
            {
                ( 1, "Alice", 1.0),
                ( 2, "Alice", 1.0),
                ( 3, "Bob", 29.99),
                ( 4, "Carol", 23.22),
                ( 5, "Dan", 33.33), 
                ( 6, "Dan", 34.56), 
                ( 7, "Alice", 1.0), 
                ( 8, "Alice", 1.0), 
                ( 9, "Bob", 45.21), 
                ( 10, "Bob", 76.54)
            };

            var result = from item in data
                         group item by item.Name
                         into g
                         select new
                         {
                             Name = g.Key,
                             Count = g.Count(), 
                             Total = g.Sum(i => i.Quantity)
                         };

            //var answer = from item in data select new { Name = item.Name, Quantity = item.Quantity };

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


        }
    }
}
