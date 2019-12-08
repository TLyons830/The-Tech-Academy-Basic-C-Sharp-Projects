using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step115
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            Console.WriteLine("Please provide us an integer");
            class1.i = (Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Please provide us with another integer. Or don't. Your choice.");
            string secondNum = (Console.ReadLine());

            if (string.IsNullOrEmpty(secondNum))
            {
                Console.WriteLine("Your first number plus your second number = " + class1.methodOne(class1.i));
            }
            else
            {
                class1.x = (Convert.ToInt32(secondNum));
                Console.WriteLine("Your first number plus your second number = " + class1.methodOne(class1.i, class1.x));
            }

            Console.ReadLine();
        }
    }
}
