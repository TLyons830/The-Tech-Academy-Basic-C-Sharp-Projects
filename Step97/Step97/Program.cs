using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step97
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "My";
            string string2 = "name";
            string string3 = "is Tyler";
            string concat = "" + string1 + " " + string2 + " " + string3 + "";
            concat = concat.ToUpper();

            Console.WriteLine(concat);

            StringBuilder paragraph = new StringBuilder();
            paragraph.Append("This is the first sentence of the paragraph.");
            paragraph.Append("This is the second sentence of the paragraph.");
            paragraph.Append("This is the third sentence of the paragraph.");
            paragraph.Append("This is the last sentence of the paragraph.");
            Console.WriteLine("\n"+paragraph+"");

            Console.ReadLine();

        }
    }
}
