using System;
using System.Collections.Generic;
using System.Text;

namespace UserDaoInvestigation
{
    class DaoTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DAO Test");

            UserDao dao = new UserDao();

            User u = new User
            {
                Name = "','',0); delete from users where id = 1;--",
                //Name = "','',0); delete from users;--",
                //Name = "','',0); drop table users;--",
                Email = "",
                Active = true
            };


            /*
            User u = new User
            {
                Name = "Sarah O''Sullivan",
                Email = "sarah@gmail.com",
                Active = false
            };
            */
            dao.AddUser(u);

            dao.Close();
        }
    }
}
