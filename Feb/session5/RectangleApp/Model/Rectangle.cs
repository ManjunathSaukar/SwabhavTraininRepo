﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp.Model
{
    internal class Rectangle
    {
        public int width;
        public int height;

        public int CalculateArea()
        {
            int area = width* height;
            return area;
        }
    }
}
