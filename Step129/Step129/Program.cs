using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step129
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { name = "Tyler", id = 1 };
            Employee employee1 = new Employee() { name = "bob", id = 2 };
            employee.lstemployees = new List<Employee>();
            employee.lstemployees.Add(employee);
            employee.lstemployees.Add(employee1);
            Person person = new Person();
            person.lstpeople = new List<Person>();

            person = person + employee;
            person = person + employee1;

            if (employee.id == employee1.id)
                Console.WriteLine("Same employee");
            else
                Console.WriteLine("Different employee");

            employee.printemployees();
            Console.ReadLine();

        }
    }
}
