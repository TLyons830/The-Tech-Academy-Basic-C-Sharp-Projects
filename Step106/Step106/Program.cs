using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step106
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int> { 22, 53, 4, 2, 91 };
                Console.WriteLine("Provide us a number please.");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                foreach (int number in numbers)
                {
                    int result = number / userNumber;
                    Console.WriteLine(number + " divided by " + userNumber + " equals: " + result);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("Program has emerged from the try/catch block");
            Console.ReadLine();
        }
    }
}
