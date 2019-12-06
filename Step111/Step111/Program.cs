using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step111
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 methods = new Class1();

            Console.WriteLine("Please provide us an integer");
            int i = (Convert.ToInt32(Console.ReadLine()));

            int resultOne = methods.AddOne(i);
            int resultTwo = methods.MinusOne(i);
            int resultThree = methods.TimesTwo(i);

            Console.WriteLine("Your integer + 1 is: "+resultOne+ "\nYour integer - 1 is: "+resultTwo+ "\nYour integer * 2 is: "+resultThree);
            Console.ReadLine();

        }
    }
}
