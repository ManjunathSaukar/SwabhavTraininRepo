using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieListLib.Model
{
    [Serializable]
    public class Movie
    {
        private string _name;
        private int _year;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public Movie(string name, int year)
        {
            Name = name;
            Year = year;
        }
    }
}
