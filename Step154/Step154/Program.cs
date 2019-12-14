using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Step154
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type a number");
            string number = Convert.ToString(Console.ReadLine());
            File.WriteAllText(@"C:\Users\Tyler\Desktop\The-Tech-Academy-Basic-C-Sharp-Projects\Step154\log154.txt", number);

            string printBack = File.ReadAllText(@"C:\Users\Tyler\Desktop\The-Tech-Academy-Basic-C-Sharp-Projects\Step154\log154.txt");
            Console.WriteLine("\nReading number from log: {0}", printBack);
            Console.ReadLine();
        }
    }
}
