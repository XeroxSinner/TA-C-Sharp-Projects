using System;

namespace Scores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console App .NET Core things.");

            string path = @"C:\Users\nylan\OneDrive\Documents\GitHub\TA-C-Sharp-Projects\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path)  ;

            double tScore = 0.0;
            Console.WriteLine("\nStudent score example work: \n");
            foreach (string line in lines)
            {
                Console.WriteLine("\n" + line);
                double score = Convert.ToDouble(line);
                tScore =+ score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("Average from " + lines.Length + " scores is: " + avgScore + ".");

            Console.ReadLine();
        }
    }
}
