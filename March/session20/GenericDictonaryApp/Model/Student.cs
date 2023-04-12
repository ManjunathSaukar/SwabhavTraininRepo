 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictonaryApp.Model
{
    internal class Student
    {
        private int _standard;
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Standard
        {
            get { return _standard; }
            set
            {
                if (value >0 && value <= 12)
                {
                    _standard = value;
                }
            }
        }
        public override int GetHashCode()
        {
            return (this.Standard+ ""+this.RollNo).GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            Student student = (Student)obj;
            return ((student.Standard==this.Standard) && (student.RollNo == this.RollNo));
        }
    }
}
