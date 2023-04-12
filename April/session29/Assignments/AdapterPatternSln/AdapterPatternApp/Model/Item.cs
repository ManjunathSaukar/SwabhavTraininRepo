using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp.Model
{
    internal interface Item
    {
        string ItemName();
        double ItemPrice();
    }
}
