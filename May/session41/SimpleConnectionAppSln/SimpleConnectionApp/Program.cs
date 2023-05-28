using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConnectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=MonoceptDB;Integrated Security=True";
            Console.WriteLine(ConfigurationManager.ConnectionStrings["devEnv"].ConnectionString);
            var connectionString = ConfigurationManager.ConnectionStrings["devEnv"].ConnectionString;

            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                Console.WriteLine($"Successfully connected to {con.Database}");
            }
            catch(Exception ex)
            {
                //Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(con.State==ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
