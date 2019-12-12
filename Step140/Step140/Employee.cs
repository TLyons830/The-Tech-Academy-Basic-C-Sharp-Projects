using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step140
{
    public class Employee

    {
        public string fName { get; set; }
        public string lName { get; set; }
        public int id { get; set; }

        public List<Employee> employees = new List<Employee>();
    }
}
