using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idz13
{
    class Class1
    {
        static public int method(int x)
        {
            if (x % 2 == 0)
            {
                x = -x;
            }
            return x;
        }
    }
}
