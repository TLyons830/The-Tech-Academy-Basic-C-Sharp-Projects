using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step117
{
    class Program
    {

        static int timesTwo(int i)
        {
            return i * 2;
        }

        static double timesTwo(double i)
        {
            return i * 2;
        }

        public static void OutParamMethod(out int i)
        {
            i = 9 / 3;
        }


        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine("Please enter an integer");
            class1.geti(Convert.ToInt32(Console.ReadLine()));
            Console.ReadLine();

            int x;
            OutParamMethod(out x);
            Console.WriteLine("Practice with out param. Nine divided by 3 = "+ x);

            int overloadOne = timesTwo(2);
            double overloadTwo = timesTwo(10.3);
            Console.WriteLine("int: "+overloadOne);
            Console.WriteLine("double: "+overloadTwo);
            Console.ReadLine();


        }
    }
}
