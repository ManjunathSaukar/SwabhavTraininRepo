using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace  RectangleEnumApp.Model
{
    internal class Rectangle
    {
        private readonly int _width;
        private readonly int _height;
        private ColorOption _color;
        private BorderOptions _border;

        public Rectangle(int width, int height, ColorOption color)
        {
            _width = ValidateSide(width);
            _height = ValidateSide(height);
            _color = color;
            _border = BorderOptions.Single;
        }
        public Rectangle(int width, int height, ColorOption color, BorderOptions border)
        {
            _width = ValidateSide(width);
            _height = ValidateSide(height);
            _color = color;
            _border = BorderOptions.Single;
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

        public ColorOption Color
        {
            get { return _color; }
            set { _color = value; }
            
        }

        public BorderOptions Border
        {
            get { return _border; }
        }
    }
}
