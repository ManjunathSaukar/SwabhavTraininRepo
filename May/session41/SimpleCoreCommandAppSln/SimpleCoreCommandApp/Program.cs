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
            Console.WriteLine("Enter a Roll No :");
            var id = Console.ReadLine();

            var connectionString = "Data Source=.\\sqlexpress;Initial Catalog=MonoceptDB;Integrated Security=True";
            var connection = new SqlConnection(connectionString);
            connection.Open();
            var query = $"select * from student where id = @studentId";
            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@studentId", id);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"{reader["name"]} {reader["location"]}");
            }
            reader.Close();
            connection.Close();
        }

        private static void CaseStudy2()
        {
            Console.WriteLine("Enter a Roll No :");
            var id = Console.ReadLine();

            var connectionString = "Data Source=.\\sqlexpress;Initial Catalog=MonoceptDB;Integrated Security=True";
            var connection = new SqlConnection(connectionString);
            connection.Open();
            var query = $"select * from student where id = {id}";
            var command = new SqlCommand(query, connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"{reader["name"]} {reader["location"]}");
            }
            reader.Close();
            connection.Close();
        }

        private static void CaseStudy1()
        {
            var connectionString = "Data Source=.\\sqlexpress;Initial Catalog=MonoceptDB;Integrated Security=True";
            var connection = new SqlConnection(connectionString);
            connection.Open();
            var query = "select * from student";
            var command = new SqlCommand(query, connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"{reader["name"]} {reader["location"]}");
            }
            reader.Close();
            connection.Close();
        }
    }
}