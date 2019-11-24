using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
    {
        static void Main(string[] args)
        {

        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("You Passed! Your score: " + testScores[i]);
        //    }
        //}

        //string[] names = { "Tyler", "Davis", "Paul", "Sue" };

        //for (int i = 0; i < names.Length; i++)
        //{       
        //    Console.WriteLine(names[i]); 
        //}

        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("You Passed! Your score: " + score);
        //    }
        //}

        //List<string> names = new List<string>() { "Tyler", "Davis", "Paul", "Sue" };

        //foreach (string name in names)
        //{
        //    if (name.EndsWith("s"))
        //    {
        //        Console.WriteLine(name);
        //    }
        //}

        List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }

        Console.WriteLine("Nunber of passing scores: " +passingScores.Count);

        foreach (int score in testScores)
        {
            Console.WriteLine(score);
        }

        Console.WriteLine("\n");

        foreach (int score in passingScores)
        {
            Console.WriteLine(score);
        }

        Console.ReadLine();
        }
    }
