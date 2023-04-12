using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeRelationApp.Model
{
    internal class Department
    {
        public Department(string name, string code)
        {
            Name = name;
            Code = code;
        }
        public string Name { get; set; }
        public string Code { get; set; }

        
    }
}
