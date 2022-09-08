using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserDaoInvestigation
{
    class UserDao
    {
        private string connectionString = @"Data Source=C:\data\oocsharp2022\users.db";
        private SqliteConnection conn;

        public UserDao()
        {
            conn = new SqliteConnection(connectionString);
            conn.Open();
        }

        public void Close()
        {
            conn.Close();
        }

        public User GetUser(int id)
        {
            User user = new User();

            string sql = $"SELECT * FROM users WHERE id = { id }";

            SqliteCommand cmd = new SqliteCommand(sql, conn);
            SqliteDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                string name = rdr.GetString(1);
                string email = rdr.GetString(2);
                bool active = rdr.GetBoolean(3);

                user = new User(id, name, email, active);
            }

            rdr.Close();

            return user;
        }
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            string sql = "SELECT * FROM users";

            SqliteCommand cmd = new SqliteCommand(sql, conn);
            SqliteDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                int id = rdr.GetInt32(0);
                string name = rdr.GetString(1);
                string email = rdr.GetString(2);
                bool active = rdr.GetBoolean(3);

                User user = new User
                {
                    Id = id,
                    Name = name,
                    Email = email,
                    Active = active
                };
                users.Add(user);
            }
            rdr.Close();
            return users;
        }
        
        public void DeleteUser(int id)
        {
            String sql = $"DELETE FROM users WHERE id = { id }";
            SqliteCommand cmd = new SqliteCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public User AddUser(User userToAdd)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User userToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
