using Microsoft.Data.Sqlite;
using System;

namespace DatabaseHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Database Hello World");

            string connectionString = @"Data Source=C:\data\oocsharp2022\users.db";
            SqliteConnection conn = new SqliteConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM users";

            SqliteCommand cmd = new SqliteCommand(sql, conn);
            SqliteDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string name = rdr.GetString(1);
                Console.WriteLine(name);
            }
            rdr.Close();
            
            conn.Close();
        }
    }
}
