using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step100
{
    class Program
    {
        static void Main()
        {

            string[] stringArray = { "String at index 0", "String at index 1", "String at index 2", "String at index 3", "String at index 4" };
            int[] intArray = { 22, 150, 35, 1, 8 };
            
            List<string> stringList = new List<string>();
            stringList.Add("Hi");
            stringList.Add("Hey");
            stringList.Add("Hello");

            Console.WriteLine("Select an integer to index our array of strings, and the result will be displayed!");
            int stringArrayIndex = Convert.ToInt32(Console.ReadLine());
            while (stringArrayIndex > 4 || stringArrayIndex < 0)
            {
                Console.WriteLine("Error, you selcted an index that does not exist. Next time, select one of the following integers : 0, 1, 2, 3, 4 ");
                stringArrayIndex = Convert.ToInt32(Console.ReadLine());
            }
            if (stringArrayIndex > 0 && stringArrayIndex < 5)
            {
                Console.WriteLine(stringArray[stringArrayIndex]);
                Console.ReadLine();
            }

            Console.WriteLine("Select an integer to index our array of integers, and the result will be displayed!");
            int intArrayIndex = Convert.ToInt32(Console.ReadLine());
            while (intArrayIndex > 4 || intArrayIndex < 0)
            {
                Console.WriteLine("Error, you selcted an index that does not exist. Next time, select one of the following integers : 0, 1, 2, 3, 4 ");
                intArrayIndex = Convert.ToInt32(Console.ReadLine());
            }
            if (intArrayIndex > 0 && intArrayIndex < 5)
            {
                Console.WriteLine(intArray[intArrayIndex]);
                Console.ReadLine();
            }

            Console.WriteLine("Select an integer to index our list of strings, and the result will be displayed!");
            int stringListIndex = Convert.ToInt32(Console.ReadLine());
            while (stringListIndex > stringList.Count || stringListIndex < 0)
            {
                Console.WriteLine("Error, you selcted an index that does not exist. Next time, select one of the following integers : 0, 1, 2 ");
                stringListIndex = Convert.ToInt32(Console.ReadLine());
            }
            if (stringListIndex > 0 && stringListIndex <= stringList.Count)
            {
                Console.WriteLine(stringList[stringListIndex]);
                Console.ReadLine();
            }
        }
    }
}
