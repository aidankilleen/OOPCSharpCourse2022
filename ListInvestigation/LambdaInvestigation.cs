using System;
using System.Collections.Generic;
using System.Text;

namespace ListInvestigation
{
    class LambdaInvestigation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lambda Investigation");

            List<User> users = new List<User>
            {
                new User { Id=1, Name="Alice", Email="alice@gmail.com", Active=false },
                new User { Id=2, Name="Bob", Email="bob@gmail.com", Active=true },
                new User { Id=3, Name="Carol", Email="carol@gmail.com", Active=true },
                new User { Id=4, Name="Dan", Email="dan@gmail.com", Active=false },
            };

            List<User> activeUsers = users.FindAll(user => !user.Active);        // lambda expression

            //Original version
            //List<User> activeUsers = users.FindAll((user) => {
            //    if(user.Active)
            //    {
            //        return true;
            //    } else
            //    {
            //        return false;
            //    }
            //});

            foreach (User user in activeUsers)
            {
                Console.WriteLine(user.Name);
            }

            List<int> list = new List<int>
            {
                1, 4, 3, 7, 5, 9, 10, 2
            };

            List<int> evenNumbers = list.FindAll(item =>item % 2 == 1);

            foreach (int item in evenNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
