using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCircleApp.Model
{
    internal class Circle
    {
        private readonly float _radius;
        private string _color;
        private string _border;

        public Circle(float radius, string color, string border)
        {
            _radius = ValidateRadius(radius);
            _color = ValidateColor(color);
            _border = ValidateBorder(border);
        }

        private float ValidateRadius(float aRadius)
        {
            if (aRadius > 10)
                return 10;
            else if (aRadius < 1)
                return 1;
            else
                return aRadius;
        }
        
        public string ValidateColor(string color)
        {
            color = color.ToLower();
            if (color == "red" || color == "blue" || color == "green")
            {
                return color;
            }
            else
            {
                return color;
            }
        }

        public string ValidateBorder(string border) 
        { 
            border=border.ToLower();
            if(border == "single border" || border == "double border" || border == "dotted border")
            {
                return border;    
            }
            else
            {
                return "single border";
            }
        }
        public float Radius
        {
            get { return _radius; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = ValidateColor(value); }
        }

        public string Border
        {
            get { return _border; }
            set { _border = ValidateBorder(value);}
        }
    }
}
