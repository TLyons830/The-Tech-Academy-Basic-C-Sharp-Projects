using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step124
{
    public class Employee : Person, IQuittable
    {

        public List<Employee> Employees { get; set; }

        public int id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Employee: ");
            base.SayName();
            Console.WriteLine("ID: "+id);
        }


        public void Quit()
        {
            Console.WriteLine("This employee is an employee object, which inherits this method from the IQuittable Inteface.");
        }
    }
}
