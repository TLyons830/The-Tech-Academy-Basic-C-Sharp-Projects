using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate?");
            string p1Rate = Console.ReadLine();
            double person1Rate = Convert.ToDouble(p1Rate);
            Console.WriteLine("Houres worked per week?");
            string p1Hours = Console.ReadLine();
            double person1Hours= Convert.ToDouble(p1Hours);

            Console.WriteLine("Person 2");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate?");
            string p2Rate = Console.ReadLine();
            double person2Rate = Convert.ToDouble(p2Rate);
            Console.WriteLine("Houres worked per week?");
            string p2Hours = Console.ReadLine();
            double person2Hours = Convert.ToDouble(p2Hours);

            double person1Salary = person1Hours * person1Rate;
            double person2Salary = person2Hours * person2Rate;


            Console.WriteLine("Weekly salary of Person 1: " + person1Salary);
            Console.ReadLine();
            Console.WriteLine("Weekly salary of Person 2: " + person2Salary);
            Console.ReadLine();

            bool whoMakesMore = person1Salary > person2Salary;
            Console.WriteLine("Does Person 1 make more money than Person 2? : " + whoMakesMore);
            Console.ReadLine();

        }
    }
}
