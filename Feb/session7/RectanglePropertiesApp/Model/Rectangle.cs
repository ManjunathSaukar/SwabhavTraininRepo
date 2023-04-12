using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorApp.Model
{
    internal class Rectangle
    {
        private readonly int _width;
        private readonly int _height;
        private string _color;

        public Rectangle(int width, int height, string color)
        {
            _width = ValidateSide(width);
            _height = ValidateSide(height);
            _color = ValidateColor(color);
        }

        private int ValidateSide(int side)
        {
            if (side > 100)
                return 100;
            else if (side < 0)
                return 1;
            else
                return side;
        }

        private string ValidateColor(string color)
        {
            color = color.ToLower();
            if (color == "red" || color == "blue" || color == "green")
            {
                return color;
            }
            else
            {
                return "red";
            }
        }


        public int CalculateArea()
        {
            int area = _width * _height;
            return area;
        }

        public int Height
        {
            get { return _height; }
        }
        public int Width
        {
            get { return _width; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = ValidateColor(value); }
        }
    }
}
