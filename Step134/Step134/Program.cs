using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step134
{
    class Program
    {
        public enum daysofWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Please enter the current day of the week.");
                string userDay = Console.ReadLine();
                Console.WriteLine("You entered in that today is: " + Enum.Parse(typeof(daysofWeek), userDay));
            }
            catch
            {
                Console.WriteLine("Please enter in an actual day of the week, capitalizing the first letter.");
            }
            Console.ReadLine();


        }
    }
}
