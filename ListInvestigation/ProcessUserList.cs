using System;
using System.Collections.Generic;
using System.Text;

namespace ListInvestigation
{
    class ProcessUserList
    {
        public delegate bool CheckFunction(User user);

        public static bool CheckInActive(User user)
        {
            return user.Active == false;
        }
        public static bool CheckActive(User user)
        {
            return user.Active == true;
        }

        public static void ScanList(List<User> users, CheckFunction checkFunction)
        {
            foreach (User user in users)
            {
                if (checkFunction(user))
                {
                    Console.WriteLine(user.Name);
                }
            }
        }
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User { Id=1, Name="Alice", Email="alice@gmail.com", Active=false },
                new User { Id=2, Name="Bob", Email="bob@gmail.com", Active=true },
                new User { Id=3, Name="Carol", Email="carol@gmail.com", Active=true },
                new User { Id=4, Name="Dan", Email="dan@gmail.com", Active=false },
            };

            ScanList(users, CheckInActive);
        }
    }
}
