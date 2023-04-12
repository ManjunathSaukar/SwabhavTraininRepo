using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPVoilationApp.Model
{
    internal class Square :Rectangle
    {
        public Square(int side) : base(side, side)
        {
        }
        public override void SetWidth(int pwidth)
        {
            _width = _height = pwidth;
        }
        public override void SetHeight(int pheight)
        {
            _width = _height = pheight;
        }
    }
}
