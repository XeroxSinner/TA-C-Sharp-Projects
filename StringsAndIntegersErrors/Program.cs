using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersErrors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool again = false;
            while (!again)
            {
                try
                {
                    List<int> numbers = new List<int>() { 3, 5, 6, 8, 57, 445 };

                    Console.WriteLine("I have a list of numbers, what would you like to divide them by? (For the sake of this excersize, we're just using int variables.)");

                    int divisor = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int answer = numbers[i] / divisor;
                        Console.WriteLine($"{numbers[i]} divided by " + divisor + " is: " + answer + ".");
                        again = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please use an integer, strings won't work.\n");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Dividing by zero destroys the universe. Let's not.\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("We've run into another error: " + ex.Message);
                }
            }

            Console.WriteLine("\nThanks! Press enter to close.");
            Console.ReadLine();

        }
    }
}
