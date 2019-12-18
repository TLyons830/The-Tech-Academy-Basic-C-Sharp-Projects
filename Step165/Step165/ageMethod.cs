using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step165
{
    public class ageMethod
    {
        public void DisplayAge(int age)
        {
            if (age < 0)
            {
                throw new AgeBelowZeroException();
            }
            if (age == 0)
            {
                throw new AgeisZeroException();
            }
            Console.WriteLine("Your age is: "+age);
        }
    }
}
