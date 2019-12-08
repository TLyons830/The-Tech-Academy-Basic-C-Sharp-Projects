using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step115
{
    public class Class1
    {
        public int i;
        public int x;

        public int methodOne (int i, int x = 0)
        {
            int result = i + x;
            return result;
        }
    }
}
