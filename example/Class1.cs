using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    internal class Class1 : Interface1
    {   
        public int Meth(int a)
        {
            return a + 1;
        }
        public int Meth1(int a)
        {
            return a + 2;
        }
    }
}
