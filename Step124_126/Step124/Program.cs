using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step124
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Employees = new List<Person>();
            Employee employee1 = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.id = 1;

            employee.SayName();
            Console.ReadLine();

            employee.Quit();
            Console.ReadLine();

        }
    }
}
