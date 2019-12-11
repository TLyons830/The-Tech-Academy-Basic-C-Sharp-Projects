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
            Employee<Person> employee = new Employee<Person>() { name = "Tyler" };
            employee.things = new List<Person>();
            Employee<Person> employee1 = new Employee<Person>() { id = 1 };
            employee1.things = new List<Person>();

            employee.things.Add(employee);
            employee1.things.Add(employee1);

            foreach (string name in employee.things)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            //Employee employee = new Employee() { name = "Tyler", id = 1 };
            //Employee employee1 = new Employee() { name = "bob", id = 2 };
            //employee.lstemployees = new List<Employee>();
            //employee.lstemployees.Add(employee);
            //employee.lstemployees.Add(employee1);
            //Person person = new Person();
            //person.lstpeople = new List<Person>();

            //person = person + employee;
            //person = person + employee1;

            //if (employee.id.Equals(employee1.id))
            //    Console.WriteLine("Same employee");
            //else
            //    Console.WriteLine("Different employee");

            //employee.printemployees();
            //Console.ReadLine();


        }
    }
}
