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
        public decimal d;
        public string s;

        public int MathOpp(int i)
        {
            int mathOpp = i + 1;
            return mathOpp;
        }

        public decimal MathOpp(decimal d)
        {
            decimal mathOpp = d * 2;
            int result = Decimal.ToInt32(mathOpp);
            return result;
        }

        public int MathOpp(string s)
        {
            int stringNum = Convert.ToInt32(s);
            int result = stringNum + 5;
            return result;
        }

    }
}
