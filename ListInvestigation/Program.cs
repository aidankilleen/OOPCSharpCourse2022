using System;
using System.Collections.Generic;

namespace ListInvestigation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List Investigation");

            List<int> list = new List<int>
            {
                1, 4, 3, 7, 5, 9, 10, 2
            };

            foreach(int item in list)
            {
                Console.WriteLine(item);
            }

            User u = new User
            {
                Id = 1,
                Name = "Aidan",
                Email = "aidan@gmail.com",
                Active = true
            };

            Console.WriteLine(u.Name);
            u.Display();

            User u2 = new User();

            u2.Display();

            //List<User> team = new List<User>();
            //team.Add();


            List<User> users = new List<User>
            {
                new User { Id=1, Name="Alice", Email="alice@gmail.com", Active=false },
                new User { Id=2, Name="Bob", Email="bob@gmail.com", Active=true },
                new User { Id=3, Name="Carol", Email="carol@gmail.com", Active=true },
                new User { Id=4, Name="Dan", Email="dan@gmail.com", Active=false },
            };

            foreach (User user in users)
            {
                user.Display();

            }

            Console.WriteLine("Even numbers:");
            // iterate the list
            // display the even numbers
            foreach(int item in list)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("Active Users:");
            // display the active users

            foreach (User user in users)
            {
                if (user.Active)
                {
                    Console.WriteLine(user.Name);
                }
            }










        }
    }
}
