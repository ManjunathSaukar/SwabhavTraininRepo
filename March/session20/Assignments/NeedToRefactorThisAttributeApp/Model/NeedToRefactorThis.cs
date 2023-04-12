using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedToRefactorThisAttributeApp.Model
{
    [AttributeUsage(AttributeTargets.All)]
    public class NeedToRefactorThis : Attribute
    {

    }
}
