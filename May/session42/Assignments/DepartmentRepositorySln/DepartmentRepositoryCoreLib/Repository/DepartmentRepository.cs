using DepartmentRepositoryCoreLib.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentRepositoryCoreLib.Repository
{
    public class DepartmentRepository
    {
        private string _connectionString;

        public DepartmentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Department> Get()
        {
            List<Department> departments = new List<Department>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT DEPTNO, DNAME, LOC FROM DEPT";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Department department = new Department
                        {
                            DEPTNO = Convert.ToInt32(reader["DEPTNO"]),
                            DNAME = Convert.ToString(reader["DNAME"]),
                            LOC = Convert.ToString(reader["LOC"])
                        };

                        departments.Add(department);
                    }
                }
            }

            return departments;
        }

        public void Add(Department department)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO DEPT (DEPTNO, DNAME, LOC) VALUES (@DEPTNO, @DNAME, @LOC)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DEPTNO", department.DEPTNO);
                command.Parameters.AddWithValue("@DNAME", department.DNAME);
                command.Parameters.AddWithValue("@LOC", department.LOC);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public int Count()
        {
            int count = 0;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT COUNT(*) FROM DEPT";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                count = (int)command.ExecuteScalar();
            }

            return count;
        }

        public async Task<List<Department>> GetAsync()
        {
            List<Department> departments = new List<Department>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT DEPTNO, DNAME, LOC FROM DEPT";
                SqlCommand command = new SqlCommand(query, connection);

                await connection.OpenAsync();

                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        Department department = new Department
                        {
                            DEPTNO = Convert.ToInt32(reader["DEPTNO"]),
                            DNAME = Convert.ToString(reader["DNAME"]),
                            LOC = Convert.ToString(reader["LOC"])
                        };

                        departments.Add(department);
                    }
                }
            }

            return departments;
        }

        public async Task AddAsync(Department department)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO DEPT (DEPTNO, DNAME, LOC) VALUES (@DEPTNO, @DNAME, @LOC)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DEPTNO", department.DEPTNO);
                command.Parameters.AddWithValue("@DNAME", department.DNAME);
                command.Parameters.AddWithValue("@LOC", department.LOC);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task<int> CountAsync()
        {
            int count = 0;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT COUNT(*) FROM DEPT";
                SqlCommand command = new SqlCommand(query, connection);

                await connection.OpenAsync();
                count = (int)await command.ExecuteScalarAsync();
            }

            return count;
        }

    }
}
