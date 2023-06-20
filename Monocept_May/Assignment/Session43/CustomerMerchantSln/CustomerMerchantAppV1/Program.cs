using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CustomerMerchantAppV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Data Source=.\\sqlexpress;Initial Catalog=monoceptDB;Integrated Security=True";

            Console.Write("Enter Customer ID: ");
            int cid = int.Parse(Console.ReadLine());

            Console.Write("Enter Merchant ID: ");
            string mid = Console.ReadLine();

            Console.Write("Enter Amount For Transaction: ");
            double amount = double.Parse(Console.ReadLine());


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Update Customer Command
                string updateCustomerSqlQuery = "UPDATE CUSTOMERS SET BALANCE = BALANCE -@Amount WHERE CID = @CID";
                using (SqlCommand cmd1 = new SqlCommand(updateCustomerSqlQuery, conn))
                {
                    cmd1.Parameters.AddWithValue("@Amount", amount);
                    cmd1.Parameters.AddWithValue("@CID", cid);

                   int rowsAffected1 = cmd1.ExecuteNonQuery();

                   if (rowsAffected1 == 0)
                   {
                        Console.WriteLine("Customer Not Found.");
                        return;
                   }
                   else
                   {
                       Console.WriteLine("Customer Transaction completed successfully.");
                   }
                }

                // Update Merchant Command
                string updateMerchantSqlQuery = "UPDATE MERCHANT SET BALANCE = BALANCE +@Amount WHERE MID = @MID";
                using (SqlCommand cmd2 = new SqlCommand(updateMerchantSqlQuery, conn))
                {
                    cmd2.Parameters.AddWithValue("@Amount", amount);
                    cmd2.Parameters.AddWithValue("@MID", mid);

                    int rowsAffected2 = cmd2.ExecuteNonQuery();

                    if (rowsAffected2 == 0)
                    {
                        Console.WriteLine("Merchant Not Found.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Merchant Transaction completed successfully.");
                    }
                }
            }
        }
    }
}