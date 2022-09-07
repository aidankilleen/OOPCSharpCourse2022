using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ListInvestigation
{
    class ListOperations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List Operations");

            List<User> users = new List<User>
            {
                new User { Id=1, Name="Alice", Email="alice@gmail.com", Active=false },
                new User { Id=2, Name="Bob", Email="bob@gmail.com", Active=true },
                new User { Id=3, Name="Carol", Email="carol@gmail.com", Active=true },
                new User { Id=4, Name="Dan", Email="dan@gmail.com", Active=false },
            };

            users.ForEach(user => Console.WriteLine(user.Name));

            // you can chain operations
            users.FindAll(user => user.Active);

            //activeUsers.Sort((a, b) => string.Compare(a.Name, b.Name));

            //activeUsers.ForEach(u => Console.WriteLine(u.Name));

           

        }
    }
}
