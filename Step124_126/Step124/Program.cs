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
            IQuittable employee = new Employee() { firstName = "interface", lastName = "practice", id = 2 };
            Employee employee1 = new Employee() { firstName = "Sample", lastName = "Student", id = 1 };
            employee1.Employees = new List<Employee>();
            employee1.Employees.Add(employee1);

            employee1.SayName();
            Console.ReadLine();

            employee.Quit(employee1.firstName);
            Console.ReadLine();

        }
    }
}
