using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step156
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Type a number.");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The number you entered is {0}. The current time in {0} hours from now will be: {1}", hours, DateTime.Now.AddHours(hours));
            Console.ReadLine();
        }
    }
}
