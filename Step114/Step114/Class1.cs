using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step114
{
    public class Class1
    {
        public int i;

        public int mathOpp(int i)
        {
            int mathOpp = i + 1;
            return mathOpp;
        }

        public decimal mathOpp(decimal i)
        {
            decimal mathOpp = i * 2;
            mathOpp = Convert.ToInt32(mathOpp);
            return mathOpp;
        }
    }
}
