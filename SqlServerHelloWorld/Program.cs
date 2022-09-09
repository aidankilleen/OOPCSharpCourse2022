using System;
using System.Data.SqlClient;

namespace SqlServerHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SqlServer Hello World");
            SqlConnection conn;

            string connectionString = "Server=tcp:nottheserver.database.windows.net,1433;Initial Catalog=trainingdb;Persist Security Info=False;User ID=nottheuser;Password=notthepassword;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            conn = new SqlConnection(connectionString);

            conn.Open();
            string sql = "SELECT * FROM users";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rdr = cmd.ExecuteReader();

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
