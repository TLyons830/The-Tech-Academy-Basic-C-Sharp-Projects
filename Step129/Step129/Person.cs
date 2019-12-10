using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step129
{
    public class Person
    {

        public string name { get; set; }

        public List<Person> lstpeople = new List<Person>();

        public void printPeople()
        {
            foreach (Person person in lstpeople)
            {
                Console.WriteLine(person.name);
            }
        }


    }
}
