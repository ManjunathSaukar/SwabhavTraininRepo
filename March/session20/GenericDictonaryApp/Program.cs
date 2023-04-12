using GenericDictonaryApp.Model;
using System.Collections.Generic;

namespace GenericDictonaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //Console.WriteLine(("10" + "1").GetHashCode());
            //Console.WriteLine(("1"+"10").GetHashCode());


            var s1 = new Student { Standard = 10, RollNo = 1, Name = "Manjunath" };
            var s2 = new Student { Standard = 10, RollNo = 2, Name = "Abhi" };
            var s3 = new Student { Standard = 10, RollNo = 1, Name = "Manjunath" };

            //Console.WriteLine(s1.Equals(s3));
            

            var students = new Dictionary<Student, Student>();
            students.Add(s1, s1);
            students.Add(s2, s2);
            students.Add(s3, s3);

            Console.WriteLine(students.Count);
        }

        private static void CaseStudy1()
        {
            Dictionary<string, string> stateCodes = new Dictionary<string, string>();
            stateCodes.Add("MH","Maharastra");
            stateCodes.Add("KA", "Karnataka");
            stateCodes.Add("KL", "Kerala");
   
            if (stateCodes.ContainsKey("KL"))
            {
                stateCodes.Remove("KL");
                stateCodes.Add("KL", "NEW KERALA");
            }
            Console.WriteLine("After updating to NEW KERALA USING Contains Key method");
            foreach (var row in stateCodes)
            {
                Console.WriteLine($"Key is {row.Key} value is {row.Value}");
            }
            Console.WriteLine();

            stateCodes["MH"] = "NEW MAHARASTRA";
            Console.WriteLine("After updating to NEW MAHARASTRA using syntax method");
            foreach (var row in stateCodes)
            {
                Console.WriteLine($"Key is {row.Key} value is {row.Value}");
            }

            Console.WriteLine(stateCodes.Count);
        }
    }
}