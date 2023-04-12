using System.Collections.Generic;

namespace GenericDictonaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
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