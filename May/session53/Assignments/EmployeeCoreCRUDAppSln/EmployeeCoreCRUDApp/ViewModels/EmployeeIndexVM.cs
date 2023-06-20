using EmployeeCoreCRUDApp.Models;

namespace EmployeeCoreCRUDApp.ViewModels
{
    public class EmployeeIndexVM
    {
        public string Title { get; set; }
        public List<Employee> Employees { get; set; }
        public int Count { get; set; }
    }
}
