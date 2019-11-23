using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step94
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old am I?");
            int age = Convert.ToInt32(Console.ReadLine());
            
            while (age != 29)
            {
                Console.WriteLine("Wrong, guess again.");
                Console.WriteLine("How old am I?");
                age = Convert.ToInt32(Console.ReadLine());
            }

            if (age == 29)
            {
                Console.WriteLine("That's Correct! ");
            }

            Console.WriteLine("  ");
            Console.WriteLine("How old am I? ");
            int myAge = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = myAge == 29;

            do
            {
                switch (myAge)
                {
                    case 28:
                        Console.WriteLine("Close, but guess again!");
                        Console.WriteLine("How old am I?");
                        myAge = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 30:
                        Console.WriteLine("Close, but guess again!");
                        Console.WriteLine("How old am I?");
                        myAge = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("Good Job");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Wrong!");
                        Console.WriteLine("How old am I?");
                        myAge = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            Console.Read();
        }
    }
}
