using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInhertanceApp.Model
{
    internal class Student : Person
    {
        private BranchOptions _branch;
        public Student(int id, string name, string address, DateTime dob, BranchOptions branch) : base(id, name, address, dob)
        {
            _branch = branch;
        }


        public override string Profession{get { return "student"; } }

        public object BranchOptions { get { return _branch; } }
    }
}
