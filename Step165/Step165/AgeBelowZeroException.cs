using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step165
{
    public class AgeBelowZeroException : Exception
    {
        public AgeBelowZeroException()
            : base() { }
        public AgeBelowZeroException(string message)
            : base(message) { }
    }
}
