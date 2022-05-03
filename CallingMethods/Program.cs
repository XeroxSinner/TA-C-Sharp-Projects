using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick an integer, please: ");
            int yourNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("We're going to put your number through some maths.");

            //Calls from methods class for use in this class
            Methods methods = new Methods();

            //Calls addTo method
            int yourNumberFin = methods.addTo(yourNumber);

            Console.WriteLine("Your number plus one is " + yourNumberFin + ". \nPress enter to multiply by two.");
            Console.ReadLine();

            //Calls multi method
            int yourNumberDbl = methods.multi(yourNumberFin);
            Console.WriteLine("And it is " + yourNumberDbl + ". \nPress enter to subtract 3.");
            Console.ReadLine();

            //Calls subFrom method
            int yourNumSub = methods.subFrom(yourNumberDbl);
            Console.WriteLine("There we go, " + yourNumSub + " is your answer. We done here. Thanks.");
            Console.ReadLine();






        }
    }
}
