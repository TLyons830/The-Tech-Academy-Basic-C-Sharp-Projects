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
            Console.WriteLine(classInt.MathOpp(classInt.i));
            Console.ReadLine();

            Class1 classDec = new Class1();
            classDec.d = 55.9M;
            Console.WriteLine(classDec.MathOpp(classDec.d));
            Console.ReadLine();

            Class1 classStr = new Class1();
            classStr.s = "10";
            Console.WriteLine(classStr.MathOpp(classStr.s));
            Console.ReadLine();
        }
    }
}
