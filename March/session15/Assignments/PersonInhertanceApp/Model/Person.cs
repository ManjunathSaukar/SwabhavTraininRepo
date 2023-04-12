using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInhertanceApp.Model
{
    internal abstract class Person
    {
        private string _name;
        private int _id;
        private string _address;
        private DateTime _dob;

        public Person(int id,string name ,string address, DateTime dob)
        {
            _name= name;
            _id = id;
            _address = address;
            _dob = dob;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _dob; }
            set { _dob = value; }
        }
        
        public abstract string Profession
        {
            get;
        }
    }
}
