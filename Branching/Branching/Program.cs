using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 22 ? "22 is a good one, congrats!" : "You chose a lame favorite number";
            Console.WriteLine(result);


            //int roomTemp = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temp at your location?");
            //int currentTemp = Convert.ToInt32(Console.ReadLine());

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temp.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temp.");
            //}
            //else if (currentTemp < roomTemp)
            //{
            //    Console.WriteLine("It is colder than room temp.");
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}

            //int currentTemp = 69;
            //int roomTemp = 70;

            //string comparisonResult = currentTemp  == roomTemp ? "It is room temp." : "It is not room temp.";
            //Console.WriteLine(comparisonResult);

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exaclty room temp.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temp.");
            //}
            //else if (currentTemp < roomTemp)
            //{
            //    Console.WriteLine("It is colder than room temp.");
            //}
            //else 
            //{
            //    Console.WriteLine("It isnt room temp.");
            //}
            Console.ReadLine();
        }
    }
}
