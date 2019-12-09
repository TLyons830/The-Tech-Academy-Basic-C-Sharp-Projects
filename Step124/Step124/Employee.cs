using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step124
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Employee: ");
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("This employee is an employee object, which inherits this method from the IQuittable Inteface.");
        }
    }
}
