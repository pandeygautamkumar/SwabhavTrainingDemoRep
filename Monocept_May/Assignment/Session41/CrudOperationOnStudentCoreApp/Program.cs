using System;
using System.Data;
using System.Data.SqlClient;

namespace CrudOperationOnStudentCoreApp
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
                while (true)
                {
                    Console.WriteLine("(1). Create New Student Data\t(2). Find A Student\t(3). Show All Student" +
                        "\t (4).Update a student\t(5). Delete a Student\t(6).Exit\n");
                    Console.Write("Enter Your Choice : ");
                    var choice = Console.ReadLine();
                    switch(choice)
                    {
                        case "1":
                            Console.Write("Enter Name : ");
                            string i_name= Console.ReadLine();
                            Console.Write("Enter Location : ");
                            string i_location= Console.ReadLine();
                            InsertIntoDB(i_name, i_location,conn);
                            break;
                        case "2":
                            Console.Write("Enter Id : ");
                            int f_id=int.Parse(Console.ReadLine());
                            FindAStudent(f_id, conn);
                            break;
                        case "3":
                            FindAllStudent(conn);
                            break;
                        case "4":
                            Console.Write("Enter Id : ");
                            int u_id= int.Parse(Console.ReadLine());
                            Console.Write("Enter Name : ");
                            string u_name = Console.ReadLine();
                            Console.Write("Enter Location : ");
                            string u_location = Console.ReadLine();
                            UpdateDB(u_id,u_name, u_location,conn);
                            break;
                        case "5":
                            Console.Write("Enter Id : ");
                            int d_id=int.Parse(Console.ReadLine());
                            DeleteFromDB(d_id,conn);
                            break;
                        case "6":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid Choice\n");
                            break;
                    }
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
        static void FindAllStudent(SqlConnection conn)
        {
            var query = "select * from Student";
            var command = new SqlCommand(query, conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                Console.WriteLine();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["id"]}   {reader["name"]}    {reader["location"]}");
                }
                Console.WriteLine();
            }
        }
        static void FindAStudent(int find_id, SqlConnection conn)
        {
            var query = "select * from Student where id=@id";
            var command=new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", find_id);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                Console.WriteLine();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["id"]}   {reader["name"]}    {reader["location"]}");
                }
                Console.WriteLine();
            }
        }
        private static void InsertIntoDB(string name,string location,SqlConnection conn)
        {
            string query = "INSERT INTO student (name,location)values(@name, @location)";
            var command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@location", location);
            int _rows = command.ExecuteNonQuery();

            if (_rows > 0)
            {
                Console.WriteLine("Command Executed successfully!\n");
            }
            else { Console.WriteLine("Failed to Inserrt!\n"); }
        }
        static void UpdateDB(int id, string name, string location, SqlConnection conn)
        {
            var query = "update Student set name=@name,location=@location where id=@id";
            var command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@location", location);

            int _rows = command.ExecuteNonQuery();
            if (_rows > 0)
            {
                Console.WriteLine($"{_rows} rows updated successfully!\n");
            }
            else { Console.WriteLine("Failed to Update!\n"); }
        }

        static void DeleteFromDB(int delete_id, SqlConnection conn)
        {
            var query = "delete from Student where id=@id";
            var command = new SqlCommand(query,conn);
            command.Parameters.AddWithValue("@id", delete_id);

            int _rows = command.ExecuteNonQuery();

            if (_rows > 0)
            {
                Console.WriteLine("Row Deleted successfully!\n");
            }
            else { Console.WriteLine("Failed to Delete/ Invalid ID!\n"); }
        }

    }
}