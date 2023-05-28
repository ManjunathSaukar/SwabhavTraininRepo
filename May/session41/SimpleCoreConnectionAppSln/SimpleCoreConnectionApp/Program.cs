using System.Data;
using System.Data.SqlClient;

namespace SimpleCoreConnectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Data Source =.\\sqlexpress; Initial Catalog = MonoceptDB; Integrated Security = True";
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                Console.WriteLine($"Successfully connected to {con.Database}");
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}