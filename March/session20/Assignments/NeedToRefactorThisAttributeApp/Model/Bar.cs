using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedToRefactorThisAttributeApp.Model
{
    public class Bar
    {
        [NeedToRefactorThis]
        public void M1() { }

        public void M2() { }

        public void M3() { }

        public void M4() { }

        [NeedToRefactorThis]
        public void M5() { }
    }
}
