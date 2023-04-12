using CollegeRelationApp.Model;

namespace CollegeRelationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            College college = new College("Methodsit College");

            Department cs = new Department("Computer Science", "CS");
            Department ec = new Department("Electronics and communication", "EC");
            Department ee = new Department("Electrical and electronics", "EE");
            Department cv = new Department("Civil", "CV");
            Department me = new Department("Mechanical", "ME");

            college.AddDepartment(cs);
            college.AddDepartment(ec);
            college.AddDepartment(ee);
            college.AddDepartment(cv);
            college.AddDepartment(me);

            college.AddStudent(new Student("Manjunath", 21, "EC001", ec));
            college.AddStudent(new Student("Madhuri", 21, "CS002", cs));
            college.AddStudent(new Student("Anirudh", 22, "ME002", me));
            college.AddStudent(new Student("Vamshi", 21, "CV002", cv));
            college.AddStudent(new Student("Prasad", 21, "EE002", ee));

            college.AddProfessor(new Professor("Dr. Krishna Kumar", 40, "Professor", ec));
            college.AddProfessor(new Professor("Dr. Srikanth Reddy", 45, "Associate Professor", cs));


            PrintDetails(college);
        }
        private static void PrintDetails(College c)
        {
            Console.WriteLine($"College Name: {c.Name}");
            Console.WriteLine("Available Departments:");

            foreach (var department in c.Departments)
            {
                Console.WriteLine($"Department Name: {department.Name}");
                Console.WriteLine($"Department Code: {department.Code}");
            }

            Console.WriteLine("\nStudents:");
            foreach (var student in c.Students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Roll Number: {student.RollNumber}, Dept : {student.Department.Name}");
            }

            Console.WriteLine("\nProfessors:");
            foreach (var professor in c.Professors)
            {
                Console.WriteLine($"Name: {professor.Name}, Age: {professor.Age}, Designation: {professor.Designation}, Department : {professor.Department.Name}");
            }
        }

    }
}