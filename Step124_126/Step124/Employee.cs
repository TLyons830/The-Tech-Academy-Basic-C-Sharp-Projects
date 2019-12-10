using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step124
{
    public class Employee : Person, IQuittable
    {

        public List<Employee> Employees = new List<Employee>();

        public int id { get; set; }


        public override void SayName()
        {
            foreach (Person person in Employees)
            {
                Console.WriteLine("Employee: ");
                base.SayName();
                Console.WriteLine("ID: " + id);
            }
        }



        public void Quit(string name)
        {
            name = firstName;
            Console.WriteLine(name+" is an employee object, which inherits this method from the IQuittable Inteface.");
        }
    }
}
