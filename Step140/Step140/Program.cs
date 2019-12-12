using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step140
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { fName = "Joe", lName = "Montana", id = 1 };
            Employee employee1 = new Employee() { fName = "Joe", lName = "Biden", id = 2 };
            Employee employee2 = new Employee() { fName = "Aaron", lName = "Rodgers", id = 3 };
            Employee employee3 = new Employee() { fName = "Davante", lName = "Adams", id = 4 };
            Employee employee4 = new Employee() { fName = "Aaron", lName = "Jones", id = 5 };
            Employee employee5 = new Employee() { fName = "Allan", lName = "Lazard", id = 6 };
            Employee employee6 = new Employee() { fName = "Kenny", lName = "Clark", id = 7 };
            Employee employee7 = new Employee() { fName = "Blake", lName = "Martinez", id = 8 };
            Employee employee8 = new Employee() { fName = "Jimmy", lName = "Graham", id = 9 };
            Employee employee9 = new Employee() { fName = "Kevin", lName = "King", id = 10 };

            employee.employees.Add(employee);
            employee.employees.Add(employee1);
            employee.employees.Add(employee2);
            employee.employees.Add(employee3);
            employee.employees.Add(employee4);
            employee.employees.Add(employee5);
            employee.employees.Add(employee6);
            employee.employees.Add(employee7);
            employee.employees.Add(employee8);
            employee.employees.Add(employee9);


            List<Employee> newList = new List<Employee>();
            foreach (Employee x in employee.employees)
            {
                if (x.fName == "Joe")
                {
                    newList.Add(x);
                }
            }

            List<Employee> newList1 = employee.employees.Where(x => x.fName == "Joe").ToList();

            List<Employee> newList2 = employee.employees.Where(x => x.id > 5).ToList();


            Console.WriteLine(newList2.Count);
            Console.ReadLine();
        }
    }
}
