using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssign369
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prints current date and time to console
            Console.WriteLine(DateTime.Now);
            //Makes current DateTime a variable we can work with
            DateTime dateValue = DateTime.Now;
            Console.WriteLine("Give me a single number please, we'll add it to the current time:");
            //Converts user string input to integer (no error handling in this, sorry...)
            int addHour = Convert.ToInt32(Console.ReadLine());
            //Takes current datetime variable and adds user input to, returns to console
            Console.WriteLine(dateValue.AddHours(addHour));


            Console.ReadLine();
        }
    }
}
