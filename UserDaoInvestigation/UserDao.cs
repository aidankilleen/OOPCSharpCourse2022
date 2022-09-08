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
            String sql = $"INSERT INTO users (name, email, active) " +
                            $"VALUES(@name,@email,@active)";

            SqliteCommand cmd = new SqliteCommand(sql, conn);

            // tell db engine to substitute the values into the tokens
            cmd.Parameters.Add(new SqliteParameter("@name", userToAdd.Name));
            cmd.Parameters.Add(new SqliteParameter("@email", userToAdd.Email));
            cmd.Parameters.Add(new SqliteParameter("@active", userToAdd.Active ? 1 : 0));

            Console.WriteLine(sql);

            cmd.ExecuteNonQuery();

            // get the id
            sql = "select last_insert_rowid()";

            cmd = new SqliteCommand(sql, conn);
            SqliteDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                int id = rdr.GetInt32(0);
                userToAdd.Id = id;
            }
            rdr.Close();
            return userToAdd;

        }
        public User AddUserInsecure(User userToAdd)
        {
            String sql = $"INSERT INTO users (name, email, active) " +
                            $"VALUES('{ userToAdd.Name }'," +
                            $"'{ userToAdd.Email }',{( userToAdd.Active ? 1 : 0 )})";

            SqliteCommand cmd = new SqliteCommand(sql, conn);

            Console.WriteLine(sql);

            cmd.ExecuteNonQuery();

            // get the id
            sql = "select last_insert_rowid()";

            cmd = new SqliteCommand(sql, conn);
            SqliteDataReader rdr = cmd.ExecuteReader();

            if(rdr.Read())
            {
                int id = rdr.GetInt32(0);
                userToAdd.Id = id;
            }
            rdr.Close();
            return userToAdd;
        }

        public User UpdateUser(User userToUpdate)
        {
            String sql = $@"UPDATE users
                            SET name = '{ userToUpdate.Name }', 
                            email = '{ userToUpdate.Email }', 
                            active = { (userToUpdate.Active ? 1 : 0) }
                            WHERE id = { userToUpdate.Id }";

            SqliteCommand cmd = new SqliteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            return userToUpdate;
        }
    }
}
