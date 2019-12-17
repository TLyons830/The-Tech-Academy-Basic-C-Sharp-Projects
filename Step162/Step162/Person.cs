using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step162
{
    class Person
    {
        public Person(string name) : this(name, 1) { }
        public Person(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
