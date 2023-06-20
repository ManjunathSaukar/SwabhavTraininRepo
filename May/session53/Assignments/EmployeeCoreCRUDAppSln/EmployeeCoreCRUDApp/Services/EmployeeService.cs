using EmployeeCoreCRUDApp.Models;

namespace EmployeeCoreCRUDApp.Services
{
    public class EmployeeService
    {
        private List<Employee> _employees= new List<Employee>();
        private static EmployeeService _instance;

        private EmployeeService()
        {
           _employees.Add(new Employee { Id = 1, Name = "Manjunath", Salary = 5000 });
           _employees.Add(new Employee { Id = 2, Name = "Vikrant", Salary = 4000 });
        }

        public static EmployeeService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new EmployeeService();
            }
            return _instance;
        }

        public int HeadCount()
        {
            return _employees.Count;
        }

        public List<Employee> Get()
        {
            return _employees;
        }

        public Employee GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Update(int id, Employee newEmp)
        {
            var emp = GetById(id);
            if (emp != null)
            {
                emp.Id = newEmp.Id;
                emp.Salary = newEmp.Salary;
                emp.Name = newEmp.Name;
            }
        }

        public void Remove(int id)
        {
            var emp = GetById(id);
            if (emp != null)
            {
                _employees.Remove(emp);
            }
        }

    }
}
