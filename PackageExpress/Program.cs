using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("First we'll need your package weight. Please enter weight in pounds.");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Unfortunately we can't ship " + weight + "lb packages. Thank you. \nPress enter to exit.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            
            Console.WriteLine("Now for package width in inches, please.");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Next is package height in inches, please.");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Finally package length in inches, please.");
            int length = Convert.ToInt32(Console.ReadLine());


            int overall = width + height + length;
            if (overall > 50)
            {
                Console.WriteLine("Unfortunately we can't ship packages with those dimensions. Thank you. \nPress enter to exit.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            int total = (weight * width * height * length) / 100;
            Console.WriteLine("Thank you for the info. Your estimated shipping cost is $" + total + ".00. \nPress enter to close.");
            Console.ReadLine();



        }
    }
}
