using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBusinessLayerLib.Model
{
    public class Movie
    {
        private readonly string _name;
        private readonly int _year;

        public Movie(string name, int year)
        {
            _name = name;
            _year = year;
        }

        public string Name => _name;

        public int Year => _year;
    }
}
