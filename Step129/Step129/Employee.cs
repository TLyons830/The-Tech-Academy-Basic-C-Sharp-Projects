using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step129
{
    public class Employee : Person
    {
        public int id { get; set; }

        public List<Employee> lstemployees = new List<Employee>();

        public void printemployees()
        {
            foreach(Employee employee in lstemployees)
            {
                Console.WriteLine(employee.name+ " ID: "+employee.id);
            }
        }

        public static Person operator+ (Person person, Employee employee)
        {
            person.lstpeople.Add(employee);
            return person;
        }


        public static bool operator ==(Employee employee, Employee employee1)
        {

            if (employee == employee1)
                return true;
            else
                return false;

        }
        public static bool operator !=(Employee employee, Employee employee1)
        {

            if (employee != employee1)
                return true;
            else
                return false;

        }









    }
}
