using System;
using System.Collections.Generic;
using System.Text;

namespace ListInvestigation
{
    class SortInvestigation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sort Investigation");

            List<int> list = new List<int>
            {
                1, 4, 3, 7, 5, 9, 10, 2
            };

            List<User> users = new List<User>
            {
                new User { Id=1, Name="Carol", Email="carol@gmail.com", Active=true },
                new User { Id=2, Name="Bob", Email="bob@gmail.com", Active=true },
                new User { Id=3, Name="Alice", Email="alice@gmail.com", Active=false },
                new User { Id=4, Name="Dan", Email="dan@gmail.com", Active=false },
            };

            list.Sort((a, b) => b - a);

            //list.Sort((a, b) =>
            //{
            //    Console.WriteLine($"comparing {a} and {b}");
            //    if (a > b)
            //    {
            //        return 1;
            //    }
            //    else if (a < b)
            //    {
            //        return -1;
            //    }
            //    else
            //    {
            //        return 0;
            //    }
            //});

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            users.Sort((a, b) =>
            {
                // sort by Id
                Console.WriteLine($"Comparing {a.Name} with {b.Name}");
                return a.Id - b.Id;

            });

            foreach(User user in users)
            {
                user.Display();
            }

            Console.WriteLine("=============================================");
            // sort by Name

            users.Sort((a, b) =>
            {
                return string.Compare(a.Name, b.Name);
            });

            foreach (User user in users)
            {
                user.Display();
            }


        }
    }
}
