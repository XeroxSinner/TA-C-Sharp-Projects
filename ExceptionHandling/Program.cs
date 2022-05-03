using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Pick a number.");
                int numOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numTwo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dividing the two...");
                int numThree = numOne / numTwo;

                Console.WriteLine("Answer is " + numThree + ".");
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errorrrrrr.");
            }
            finally
            {
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
