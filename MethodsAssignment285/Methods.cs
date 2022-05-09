using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment285
{
    public class Methods
    {
        //Void method - no output
        public void Half(double a)
        {
            Console.WriteLine("That number halved is: " + (a / 2));
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public string Add(string a, string b)
        {
            string s = a + b;
            return s;
        }
    }

    public static class Methods2
    {
        public static string fName = "Ny";
        public static string lName = "Arce";
        public static void Names()
        {
            Console.WriteLine("My name is");
        }
    }

    
}
