using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedToRefactorThisAttributeApp.Model
{
    public class Foo
    {
        public void M1() { }

        [NeedToRefactorThis]
        public void M2() { }

        [NeedToRefactorThis]
        public void M3() { }

        public void M4() { }
    }
}
