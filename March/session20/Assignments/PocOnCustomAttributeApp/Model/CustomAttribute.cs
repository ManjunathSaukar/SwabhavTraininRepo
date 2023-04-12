using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnCustomAttributeApp.Model
{
    [AttributeUsage(AttributeTargets.All)]
    public class CustomAttribute : Attribute
    {
        public string CustomValue { get; set; }

        public CustomAttribute(string customValue)
        {
            CustomValue = customValue;
        }
    }
}
