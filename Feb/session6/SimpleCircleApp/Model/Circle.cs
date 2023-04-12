using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCircleApp.Model
{
    internal class Circle
    {
        private float _radius;
        private string _color;
        private string _border;

        private void SetDimension(ref float dimension, int value)
        {
            if (value > 10)
                dimension = 10;
            else if (value < 1)
                dimension = 1;
            else
                dimension = value;
        }
        public void SetRadius(int pradius)
        {
            SetDimension(ref _radius, pradius);
        }

        public float GetRadius()
        {
            return _radius;
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
        public void SetBorder(string pborder) 
        { 
            pborder=pborder.ToLower();
            if(pborder == "single border" || pborder == "double border" || pborder == "dotted border")
            {
                _border = pborder;    
            }
            else
            {
                _border = "single border";
            }
        }
        public string GetBorder()
        {
            return _border;
        }
    }
}
