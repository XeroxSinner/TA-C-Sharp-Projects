using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1 - Simple while loop utilizing <= to progress
            Console.WriteLine("First we're starting with a basic While loop, with the condition to stop when the count reaches five. \nPress enter.");
            Console.ReadLine();

            int number = 1;
            while (number <= 5)
            {
                Console.WriteLine("Counting up..." + number);
                number = number + 1;
            }
            Console.WriteLine("And done... Next is a do/while with switches talking about fruit. \nGo ahead, press enter.");
            Console.ReadLine();

            //Part 2 - Do/While with switches
            Console.WriteLine("Tell me your favorite fruit. \n(Hint: Apple, Banana, Peach are non-default..)");
            //The instruction video shows declaring the variable here.. like so..
            //string fruit = Console.ReadLine().ToLower();
            //However when I put this here, I get CS0136 error code, not allowing me to declare the var in the switch
            bool faveFruit = false;

            do
            {
                //String var declared here, see comments above
                string fruit = Console.ReadLine().ToLower();
                //switch statements and default if none apply
                switch (fruit)
                {
                    case "apple":
                        Console.WriteLine("Apples are a great standard. How 'bout another one?");

                        break;
                    case "banana":
                        Console.WriteLine("I also enjoy bananas. Pick another fruit.");

                        break;
                    case "peach":
                        Console.WriteLine("Peaches are *the best.* No need to pick more, great!");
                        faveFruit = true;
                        break;
                    default:
                        Console.WriteLine("There's so many fruits out there, pick another.");

                        break;
                }
            }
            //References the bool, while false, continue to repeat until true. 'Peach' will override the bool
            while (!faveFruit);

            Console.Read();


           
        }
    }
}
