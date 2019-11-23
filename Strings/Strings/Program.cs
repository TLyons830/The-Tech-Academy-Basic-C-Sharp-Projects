using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Tyler";
            //string quote = "The man said \"Hey\", "+name+". \non a new line. \t on a new tab";
            //string fileName = @"C:\Users\Tyler";

            //bool trueOrFalse = name.Contains("T");
            //trueOrFalse = name.EndsWith("r");

            //int length = name.Length;

            //name = name.ToUpper();

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Tyler");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
