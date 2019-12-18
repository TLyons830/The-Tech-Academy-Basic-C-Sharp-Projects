using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step165
{
    class Program
    {
        static void Main(string[] args)
        {
            ageMethod ageMethod = new ageMethod();
            Console.WriteLine("Please type your age.");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                ageMethod.DisplayAge(age);
            }
            catch (AgeBelowZeroException)
            {
                Console.WriteLine("It's impossible to have an age below zero!");
                Console.ReadLine();
                return;
            }
            catch (AgeisZeroException)
            {
                Console.WriteLine("It's impossible for your age to be zero!");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured. Please contact your system admin");
                Console.ReadLine();
                return;
            }
            Console.ReadLine();
        }
    }
}
