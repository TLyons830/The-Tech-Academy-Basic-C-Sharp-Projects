using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step113
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.i = 1;
            class1.x = 2;

            class1.mathOpp(4, 5);

            class1.mathOpp(class1.i, class1.x);



        }
    }
}
