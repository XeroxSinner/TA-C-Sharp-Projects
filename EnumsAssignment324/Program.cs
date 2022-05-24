using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment324
{
    internal class Program
    {


        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }


        static void Main(string[] args)
        {
            bool again = false;
            DaysOfTheWeek dotw;
            while (!again)
            {
                try
                {
                    Console.WriteLine("Type a day of the week:");
                    if (Enum.TryParse(Console.ReadLine(), true, out dotw))
                    {
                        Console.WriteLine(dotw + " is valid.");
                        again = true;
                    }
                    else
                        throw new Exception();
                }

                catch (Exception)
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }

                Console.ReadLine();

        }
    }
}


