using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 58, 85, 71, 97 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            string[] names = { "Jesse", "Ny", "Sera", "Remi", "Ellis" };

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "Ny")
                {
                    Console.WriteLine(names[i]);
                }
            }
            Console.ReadLine();

        }
    }
}
