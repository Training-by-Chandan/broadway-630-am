using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class Class1
    {
        public int publicVal = 10;
        protected int protectedval = 10;
        private int privateVal = 10;
        internal int internalInt = 10;
        protected internal int protectedInternalVal = 10;
    }

    public class Class2 : Class1
    {
    }

    public class TestClass
    {
        private void TestFunction()
        {
            Class1 c1 = new Class1();
        }
    }
}