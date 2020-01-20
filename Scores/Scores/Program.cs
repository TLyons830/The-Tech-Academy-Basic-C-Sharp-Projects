using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first name.");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome {uName}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\Tyler\Desktop\The-Tech-Academy-Basic-C-Sharp-Projects\Scores\Scores\StudentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            double tScore = 0.0;

            Console.WriteLine("\nStudent Scores: \n");

            foreach (string line in lines)
            {
                Console.WriteLine("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avScore = tScore / lines.Length;
            Console.WriteLine("\nThere were " + lines.Length + " student scores.");
            Console.WriteLine("\nThe average score was: " + avScore);

            Console.ReadLine();
        }
    }
}
