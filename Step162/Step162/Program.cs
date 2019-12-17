using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step162
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person("Tyler");
            
            const string myConst = "This is my const variable practice";
            Console.WriteLine(myConst);
            var myVarPractice = "Varpractice";
            Console.WriteLine(myVarPractice);
            Console.WriteLine(newPerson.Name+" "+newPerson.Id);

            Console.ReadLine();
        }
    }
}
