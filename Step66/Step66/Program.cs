using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step66
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Type a Number:");
            string number = Console.ReadLine();
            double userNumber = Convert.ToDouble(number);
            Console.WriteLine("Your Number Muliplied by 50 is: " + userNumber * 50);
            Console.ReadLine();

            Console.WriteLine("Type another Number:");
            string number2 = Console.ReadLine();
            double userNumber2 = Convert.ToDouble(number2);
            double total = userNumber2 + 25;
            Console.WriteLine("Your Number Plus 25 is: " + total);
            Console.ReadLine();

            Console.WriteLine("Type another Number:");
            string number3 = Console.ReadLine();
            double userNumber3 = Convert.ToDouble(number3);
            double total2 = userNumber3 / 12.5;
            Console.WriteLine("Your Number Divided by 12.5 is: " + total2);
            Console.ReadLine();

            Console.WriteLine("Type another Number:");
            string number4 = Console.ReadLine();
            double userNumber4 = Convert.ToDouble(number4);
            bool greaterThan50 = userNumber4 > 50;
            Console.WriteLine("Is your number greater than 50? :  " + greaterThan50);
            Console.ReadLine();

            Console.WriteLine("Type another Number:");
            string number5 = Console.ReadLine();
            double userNumber5 = Convert.ToDouble(number5);
            double remainder = userNumber5 % 7;
            Console.WriteLine("The remainder of your number divided by 7 is :  " + remainder);
            Console.ReadLine();


        }
    }
}
