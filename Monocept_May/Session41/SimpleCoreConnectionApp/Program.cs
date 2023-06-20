using System.Data;
using System;
using System.Data.SqlClient;

namespace SimpleCoreConnectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Data Source=.\\sqlexpress;Initial Catalog=monoceptDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                Console.WriteLine("(.net Core) Successfully Connected to {0}", conn.Database);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}