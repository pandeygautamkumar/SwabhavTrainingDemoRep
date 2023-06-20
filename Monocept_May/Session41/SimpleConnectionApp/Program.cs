
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SimpleConnectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=monoceptDB;Integrated Security=True";
            //Console.WriteLine(ConfigurationManager.ConnectionStrings["productionEnv"].ConnectionString);
            var connectionString=ConfigurationManager.ConnectionStrings["productionEnv"].ConnectionString;
            SqlConnection conn=new SqlConnection(connectionString);
            try
            {
                conn.Open();
                Console.WriteLine("Successfully Connected to {0}", conn.Database);
            }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(conn.State==ConnectionState.Open) 
                {
                    conn.Close();
                }
            }
        }
    }
}
