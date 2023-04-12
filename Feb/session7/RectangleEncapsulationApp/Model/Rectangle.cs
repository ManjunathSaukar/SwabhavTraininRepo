using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulationApp.Model
{
    internal class Rectangle
    {
        private int _width;
        private int _height;
        private string _color;

        private void SetDimension(ref int dimension, int value)
        {
            if (value > 100)
                dimension = 100;
            else if (value < 1)
                dimension = 1;
            else
                dimension = value;
        }

        public int CalculateArea()
        {
            int area = _width * _height;
            return area;
        }

        public void SetWidth(int pwidth)
        {
            /*if (pwidth > 100)
                _width = 100;
            else if (pwidth < 1 )
                _width = 1;
            else
                _width = pwidth;*/
            SetDimension(ref _width, pwidth);

        }

        public int GetWidth()
        {
            return _width;
        }

        public void SetHeight(int pheight)
        {
            /*if (pheight > 100)
                _height = 100;
            else if (pheight < 1)
                _height = 1;
            else
                _height = pheight;*/
            SetDimension(ref _height, pheight);
        }

        public int GetHeight()
        {
            return _height;
        }

        public void SetColor(string pcolor)
        {
            pcolor = pcolor.ToLower();
            if (pcolor == "red" || pcolor == "blue" || pcolor == "green")
            {
                _color = pcolor;
            }
            else
            {
                _color = "red";
            }
        }

        public string GetColor() 
        {
            return _color;
        }
    }
}
