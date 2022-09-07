using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ListInvestigation
{
    class LinqFunctionsInvestigations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linq Functions Investigation");

            List<User> users = new List<User>
            {
                new User { Id=6, Name="Alice", Email="alice@gmail.com", Active=true },
                new User { Id=5, Name="Eve", Email="eve@gmail.com", Active=false },
                new User { Id=2, Name="Bob", Email="bob@gmail.com", Active=true },
                new User { Id=3, Name="Carol", Email="carol@gmail.com", Active=true },
                new User { Id=4, Name="Fred", Email="fred@gmail.com", Active=true },
                new User { Id=1, Name="Dan", Email="dan@gmail.com", Active=false },
            };

            users.Where(user => !user.Active)
                .OrderBy(user => user.Name)
                .ToList()
                .ForEach(user => Console.WriteLine(user.Name));



            //IEnumerable<User> result = users.Where(user => !user.Active);
            //IOrderedEnumerable<User> sorted = result.OrderBy(user => user.Id);
            //sorted.ToList().ForEach(user => Console.WriteLine(user.Name));



        }
    }
}
