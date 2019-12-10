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
            Employee employees = new List();
            employee.Employees.Add{ employee.firstName = "Sample", employee.lastName = "student", employee.id = 1 };

            employee.SayName();
            Console.ReadLine();

            employee.Quit();
            Console.ReadLine();

        }
    }
}
