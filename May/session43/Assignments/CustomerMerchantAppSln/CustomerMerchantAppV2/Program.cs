using System.Data.SqlClient;

namespace CustomerMerchantAppV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=MonoceptDB;Integrated Security=True";

            Console.Write("Enter CID: ");
            int cid = int.Parse(Console.ReadLine());

            Console.Write("Enter MID: ");
            string mid = Console.ReadLine();

            Console.Write("Enter Amount to transact: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Check if Merchant exists
                    string checkMerchantSql = "SELECT COUNT(*) FROM Merchant WHERE MID = @MID";
                    using (SqlCommand checkMerchantCmd = new SqlCommand(checkMerchantSql, connection, transaction))
                    {
                        checkMerchantCmd.Parameters.AddWithValue("@MID", mid);
                        int merchantCount = Convert.ToInt32(checkMerchantCmd.ExecuteScalar());

                        if (merchantCount == 0)
                        {
                            Console.WriteLine("Merchant not found.");
                            transaction.Rollback();
                            return;
                        }
                    }

                    // Update Customer command
                    string updateCustomerSql = "UPDATE Customer SET Balance = Balance - @Amount WHERE CID = @CID";
                    using (SqlCommand cmd1 = new SqlCommand(updateCustomerSql, connection, transaction))
                    {
                        cmd1.Parameters.AddWithValue("@Amount", amount);
                        cmd1.Parameters.AddWithValue("@CID", cid);

                        int rowsAffected1 = cmd1.ExecuteNonQuery();

                        if (rowsAffected1 == 0)
                        {
                            Console.WriteLine("Customer not found.");
                            transaction.Rollback();
                            return;
                        }
                    }

                    // Update Merchant command
                    string updateMerchantSql = "UPDATE Merchant SET Balance = Balance + @Amount WHERE MID = @MID";
                    using (SqlCommand cmd2 = new SqlCommand(updateMerchantSql, connection, transaction))
                    {
                        cmd2.Parameters.AddWithValue("@Amount", amount);
                        cmd2.Parameters.AddWithValue("@MID", mid);

                        int rowsAffected2 = cmd2.ExecuteNonQuery();

                        if (rowsAffected2 == 0)
                        {
                            Console.WriteLine("Merchant update failed.");
                            transaction.Rollback();
                            return;
                        }
                    }

                    transaction.Commit();
                    Console.WriteLine("Transaction completed successfully.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }
    }
}