using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPVoilationRefactorApp.Model
{
    internal class Rectangle :IPolygon
    {
        private int _width;
        private int _height;

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }
        public int CalculateArea()
        {
            return _width * _height;
        }
        public void SetWidth(int pwidth)
        {
            _width = pwidth;
        }
        public int GetWidth()
        {
            return _width;
        }
        public void SetHeight(int pheight)
        {
            _height = pheight;
        }
        public int GetHeight()
        {
            return _height;
        }
    }
}
