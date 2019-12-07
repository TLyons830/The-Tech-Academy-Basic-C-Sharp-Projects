using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step114
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 classInt = new Class1();
            classInt.i = 12;
            int resultOne = classInt.mathOpp(classInt.i);
            Console.WriteLine(resultOne);
            Console.ReadLine();

            Class1 classDec = new Class1();
            classDec.i = Decimal.ToInt32(20.2M);
            int resultTwo = classDec.mathOpp(classDec.i);
            Console.WriteLine(resultTwo);
            Console.ReadLine();


        }
    }
}
