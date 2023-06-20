
using System.Data;
using System.Data.SqlClient;

namespace DepartmentDataLibApp.Model
{
    public class DepartmentRepository
    {
        public List<Department> Get()
        {
            List<Department> departments = new List<Department>();
            var connectionString = "Data Source=.\\sqlexpress;Initial Catalog=monoceptDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                var query = "SELECT * FROM DEPT";
                var command = new SqlCommand(query, conn);
                var reader=command.ExecuteReader();

                while (reader.Read())
                {
                    departments.Add(new Department
                    {
                        Dno = int.Parse(reader["DEPTNO"].ToString()),
                        Dname = reader["DNAME"].ToString(),
                        Location = reader["LOC"].ToString()
                    });
                }
                reader.Close();
                conn.Close();
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
            return departments;
        }
        public void AddDepartment(Department department)
        {
            var connectionString = "Data Source=.\\sqlexpress;Initial Catalog=monoceptDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();

                string query = "INSERT INTO DEPT (DEPTNO,DNAME,LOC)values(@dno,@dname, @location)";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@dno", department.Dno);
                command.Parameters.AddWithValue("@dname", department.Dname);
                command.Parameters.AddWithValue("@location", department.Location);
                int _rows = command.ExecuteNonQuery();

                if (_rows > 0)
                {
                    Console.WriteLine("Command Executed successfully!\n");
                }
                else { Console.WriteLine("Failed to Inserrt!\n"); }

                conn.Close();
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
        public int CountDepartment()
        {
            var connectionString = "Data Source=.\\sqlexpress;Initial Catalog=monoceptDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();

                string query = "SELECT COUNT(DISTINCT DNAME) AS NO_OF_DEPT FROM DEPT";
                var command = new SqlCommand(query, conn);

                int rows=Convert.ToInt32( command.ExecuteScalar().ToString());
                conn.Close();
                return rows;
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
            return 0;
        }
        public Task<List<Department>> GetAsync()
        { 
            return Task.Run(() =>
            {
                return Get();
            });
        }
        public Task AddAstnc(Department department)
        {
            return Task.Run(() =>
            {
                AddDepartment(department);
            });
        }
        public Task<int> CountAsync()
        {
            return Task.Run(() =>
            {
                return CountDepartment();
            });
        }
    }
}
