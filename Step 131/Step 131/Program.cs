using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_131
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees<string> employees = new Employees<string>() { name = "Tyler" };
            employees.things = new List<string>() { "a", "b", "c", "d" };

            Employees<int> employees1 = new Employees<int>() { id = 1 };
            employees1.things = new List<int>() { 1, 2, 3, 4 };

            foreach (string name in employees.things)
            {
                Console.WriteLine(name);
            }
            foreach (int id in employees1.things)
            {
                Console.WriteLine(id);
            }
            Console.ReadLine();
        }
    }
}
