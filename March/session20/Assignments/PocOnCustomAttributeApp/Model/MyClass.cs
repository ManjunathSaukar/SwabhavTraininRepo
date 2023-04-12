using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnCustomAttributeApp.Model
{
    [Custom("This is a Custom Attribute")]
    public class MyClass
    {
        public void MyMethod()
        {
            // ...
        }
    }
}
