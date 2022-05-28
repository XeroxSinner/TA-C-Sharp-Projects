using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssign365
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number: ");
            string number = Console.ReadLine();
            //uses StreamWriter from System.IO, identifies the path of the file to write to
            using (StreamWriter file = new StreamWriter(@"C:\Users\nylan\OneDrive\Desktop\Assign365.txt"))
            {
                file.WriteLine(number);
            }
            //declares returnText variable as reading all the text from set filepath
            string returnText = System.IO.File.ReadAllText(@"C:\Users\nylan\OneDrive\Desktop\Assign365.txt");
            Console.WriteLine("Your number is: " + returnText);

            Console.ReadLine(); 


        }
    }
}
