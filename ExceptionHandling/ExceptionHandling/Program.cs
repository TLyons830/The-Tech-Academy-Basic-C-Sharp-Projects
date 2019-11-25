using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nDividing the two");
                int number3 = number1 / number2;
                Console.WriteLine(number1 + " divided by " + number2 + "equals: " + number3);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            

        }
    }
}
