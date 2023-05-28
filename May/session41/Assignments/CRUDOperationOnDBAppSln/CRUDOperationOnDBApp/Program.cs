using System.Data.SqlClient;

namespace CRUDOperationOnDBApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Data Source=.\\sqlexpress;Initial Catalog=MonoceptDB;Integrated Security=True";
            Console.WriteLine("CRUD Operations on Student Database");
            Console.WriteLine("===================================");

            while (true)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Read all students");
                Console.WriteLine("2. Create a new student");
                Console.WriteLine("3. Update a student");
                Console.WriteLine("4. Read a specific student");
                Console.WriteLine("5. Delete a student");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice (1-6): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ReadStudents(connectionString);
                        break;
                    case "2":
                        Console.WriteLine("Enter student name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter student location:");
                        string location = Console.ReadLine();
                        CreateStudent(connectionString, name, location);
                        break;
                    case "3":
                        Console.WriteLine("Enter student ID:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the new name:");
                        string newName = Console.ReadLine();
                        Console.WriteLine("Enter the new location:");
                        string newLocation = Console.ReadLine();
                        UpdateStudent(connectionString, id, newName, newLocation);
                        break;
                    case "4":
                        Console.WriteLine("Enter student ID:");
                        int readId = int.Parse(Console.ReadLine());
                        ReadStudent(connectionString, readId);
                        break;
                    case "5":
                        Console.WriteLine("Enter student ID:");
                        int deleteId = int.Parse(Console.ReadLine());
                        DeleteStudent(connectionString, deleteId);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }

        }
        static void CreateStudent(string connectionString, string name, string location)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO student (name, location) VALUES ( @Name, @Location)";
                SqlCommand command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Location", location);

                connection.Open();
                command.ExecuteNonQuery();
            }

            Console.WriteLine("Student created successfully.");
        }
        static void ReadStudents(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id, name, location FROM student";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Student List:");
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string location = reader.GetString(2);

                        Console.WriteLine($"ID: {id}, Name: {name}, Location: {location}");
                    }
                }
            }
        }
        static void ReadStudent(string connectionString, int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id, name, location FROM student WHERE id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string name = reader.GetString(1);
                        string location = reader.GetString(2);

                        Console.WriteLine($"Student Details - ID: {id}, Name: {name}, Location: {location}");
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                }
            }
        }
        static void UpdateStudent(string connectionString, int id, string newName, string newLocation)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE student SET name = @Name, location = @Location WHERE id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", newName);
                command.Parameters.AddWithValue("@Location", newLocation);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Student updated successfully.");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }
        }
        static void DeleteStudent(string connectionString, int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM student WHERE id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Student deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }
        }

    }
}