using System;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace RectangleUnitTestApp.Model
{
    internal class Rectangle
    {
        public int width;
        public int height;

        public Rectangle()
        {

        }
        public Rectangle(int width, int height)
        {
            if (width <= 0)
            {
                throw new ArgumentException("Width must be greater than zero");
            }

            if (height <= 0)
            {
                throw new ArgumentException("Height must be greater than zero");
            }
            this.width = width;
            this.height = height;
        }

        public int CalculateArea()
        {
            int area = width* height;
            return area;
        }
    }
}
