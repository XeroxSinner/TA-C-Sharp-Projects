using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssign388
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValid = false;

            while (!isValid)
            {
                try
                {
                    Console.WriteLine("Here's a simple console app that should put out the year you were born. \nLet's try. How old are you?");
                    int age = Convert.ToInt32(Console.ReadLine());
                    //If statement to catch specific exception
                    if (age <= 0)
                    {
                        throw new NewExceptions();
                    }

                    DateTime now = DateTime.Now;
                    int yearBorn = now.Year - age;
                isValid = true;
                Console.WriteLine("Your age is {0}.", age);
                Console.WriteLine("You were born in {0}.", yearBorn);

                }

                //catch statements for specific exceptions
                catch (NewExceptions)
                {
                    Console.WriteLine("Your age cannot be zero or less. \n");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please use numeric digits as a whole number, no decimals. \n");
                }
                catch (Exception)
                {
                    Console.WriteLine("You've run into an unknown error, apologies. \n");
                }

            }

        Console.ReadLine();
        }
    }
}
