﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is a comment

            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: "+ total);
            //Console.ReadLine();

            bool isStudying = true;
            byte hoursWorked = 45;
            sbyte currentTemp = -8;
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m;

            double heightInCm = 250.22222;

            float secondsLeft = 2.22f;

            short tempOnMars = -341;

            int currentAge = 29;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);

            Console.WriteLine(rainingStatus);
            Console.ReadLine();

        }
    }
}
