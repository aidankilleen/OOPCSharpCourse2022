using System;
using System.Collections.Generic;

namespace UserDaoInvestigation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Dao Investigation");

            UserDao dao = new UserDao();


            dao.DeleteUser(4);


            List<User> users = dao.GetUsers();

            foreach (User user in users)
            {
                Console.WriteLine(user);
            }


            User u = dao.GetUser(3);

            Console.WriteLine(u); 


            // close the dao
            dao.Close();
        }
    }
}
