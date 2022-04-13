using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDatatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String Variable Ctrl K then C to comment, U to uncomment
            Console.WriteLine("What's your name?");
            string myName = Console.ReadLine();
            Console.WriteLine("Your name is " + myName + ".");
            Console.ReadLine();

            //Int Variable
            Console.WriteLine("What's your fave number?");
            string faveNumber = Console.ReadLine();
            int faveNum = Convert.ToInt32(faveNumber);
            int total = faveNum + 5;
            Console.WriteLine("Your fave number plus five is " + total + ".");
            Console.ReadLine();

            bool isWorking = false;
            byte hrsWorked = 42;
            sbyte temp = -23;
            char oneX = 'X';
            char inUnicode = '\u2103';
            decimal money = 100.5m; //m is required to denote decimal, largest type that takes decimal
            double heightInCm = 211.346734;
            float secondsLeft = 2.35f; //f for floats
            short tempOutside = -345;

            // Conv int to string
            int currentAge = 40;
            string yearsOld = currentAge.ToString();

            // Conv bool to string
            bool isRaining = false;
            string outsideRain = Convert.ToString(isRaining);
            Console.WriteLine(outsideRain);
            Console.ReadLine();

        }
    }
}
