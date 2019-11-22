using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step75
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age ?");
            string age = Console.ReadLine();
            int userAge = Convert.ToInt32(age);

            Console.WriteLine("Have you ever had a DUI? Answer 'true' or 'false'");
            string dui = Console.ReadLine();
            bool duiYesorNo = Convert.ToBoolean(dui);

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int speedingTickets = Convert.ToInt32(tickets);

            bool qualified = userAge > 15 && duiYesorNo == false && speedingTickets <= 3;
            
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);
            Console.ReadLine();



        }
    }
}
