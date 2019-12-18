using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step165
{
    public class AgeisZeroException : Exception
    {
        public AgeisZeroException()
            : base() { }
        public AgeisZeroException(string message)
            : base(message) { }
    }
}
