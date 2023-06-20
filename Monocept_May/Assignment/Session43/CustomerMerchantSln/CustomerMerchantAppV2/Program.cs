using System.Data.SqlClient;

namespace CustomerMerchantAppV2
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
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    int rowAffectedCustomer = 0;
                    int rowAffectedMerchant = 0;
                    // Update Customer Command
                    string updateCustomerSqlQuery = "UPDATE CUSTOMERS SET BALANCE = BALANCE -@Amount WHERE CID = @CID";
                    using (SqlCommand cmd1 = new SqlCommand(updateCustomerSqlQuery, conn,transaction))
                    {
                        cmd1.Parameters.AddWithValue("@Amount", amount);
                        cmd1.Parameters.AddWithValue("@CID", cid);

                        rowAffectedCustomer = cmd1.ExecuteNonQuery();

                        if (rowAffectedCustomer == 0)
                        {
                            Console.WriteLine("Customer Not Found.");
                        }
                        else
                        {
                            Console.WriteLine("Customer Transaction completed successfully.");
                        }
                    }
                    
                    // Update Merchant Command
                    string updateMerchantSqlQuery = "UPDATE MERCHANT SET BALANCE = BALANCE +@Amount WHERE MID = @MID";
                    using (SqlCommand cmd2 = new SqlCommand(updateMerchantSqlQuery, conn,transaction))
                    {
                        cmd2.Parameters.AddWithValue("@Amount", amount);
                        cmd2.Parameters.AddWithValue("@MID", mid);

                        rowAffectedMerchant = cmd2.ExecuteNonQuery();

                        if (rowAffectedMerchant == 0)
                        {
                            Console.WriteLine("Merchant Not Found.");
                        }
                        else
                        {
                            Console.WriteLine("Merchant Transaction completed successfully.");
                        }
                    }

                    if(rowAffectedCustomer!=0 && rowAffectedMerchant!=0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        transaction.Rollback();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    transaction.Rollback();
                }
            }
        }
    }
}