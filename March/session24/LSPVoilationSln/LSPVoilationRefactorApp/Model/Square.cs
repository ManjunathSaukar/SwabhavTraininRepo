using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPVoilationRefactorApp.Model
{
    internal class Square : IPolygon
    {
        private int _side;

        public Square(int side)
        {
            _side = side;
        }
        public void SetSide(int pside)
        {
            _side= pside;
        }
        public int GetSide()
        {
            return _side;
        }
        public int CalculateArea()
        {
            return _side * _side;
        }
    }
}
