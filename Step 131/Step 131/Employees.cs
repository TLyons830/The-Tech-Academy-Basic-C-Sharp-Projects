using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_131
{
    class Employees<T>
    {
        public List<T> things { get; set; }

        public T name { get; set; }
        public T id { get; set; }
    }
}
