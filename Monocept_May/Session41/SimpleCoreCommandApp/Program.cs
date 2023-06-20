using System.Data;
using System;
using System.Data.SqlClient;

namespace SimpleCoreCommandApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();
        }

        private static void CaseStudy3()
        {
            Console.Write("Enter a id: ");
            var id = Console.ReadLine();

            var connectionString = "Data Source=.\\sqlexpress;Initial Catalog=monoceptDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                //Console.WriteLine("(.net Core) Successfully Connected to {0}", conn.Database); ;

                var query = "select * from student where id=@studentId";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@studentId", id);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["name"]);
                }
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

        private static void CaseStudy2()
        {
            Console.Write("Enter a id: ");
            var id = Console.ReadLine();

            var connectionString = "Data Source=.\\sqlexpress;Initial Catalog=monoceptDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                //Console.WriteLine("(.net Core) Successfully Connected to {0}", conn.Database); ;

                var query = "select * from student where id=" + id;
                var command = new SqlCommand(query, conn);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["name"]);
                }
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

        private static void CaseStudy1()
        {
            var connectionString = "Data Source=.\\sqlexpress;Initial Catalog=monoceptDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                Console.WriteLine("(.net Core) Successfully Connected to {0}", conn.Database); ;

                var query = "select * from student";
                var command = new SqlCommand(query, conn);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["name"]);
                }
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