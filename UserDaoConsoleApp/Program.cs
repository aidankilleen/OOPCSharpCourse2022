using System;
using System.Collections.Generic;
using UserDaoImplementation;

namespace UserDaoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Dao Console App");

            UserDao dao = new UserDao(@"C:\data\oocsharpdbbackup\users.db");
            List<User> users = dao.GetUsers();

            users.ForEach(user => Console.WriteLine(user));

            dao.Close();

        }
    }
}
