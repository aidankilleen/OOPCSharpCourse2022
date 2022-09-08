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

            u.Name = "CHANGED";
            u.Email = "changed@gmail.com";
            u.Active = !u.Active;

            dao.UpdateUser(u);

            Console.WriteLine(u);

            User userToAdd = new User
            {
                Name = "New User",
                Email = "new.user@gmail.com",
                Active = false
            };

            User addedUser = dao.AddUser(userToAdd);

            Console.WriteLine(addedUser);  // should have an id

            // close the dao
            dao.Close();
        }
    }
}
