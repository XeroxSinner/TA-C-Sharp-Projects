using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment281
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calling method from class
            VoidMethod voidMethod = new VoidMethod();

            //Calls method, passing in two numbers
            voidMethod.Params(4, 7);

            //Calls method, specifies parameters by name
            voidMethod.Params(a: 5, b: 6);

            Console.ReadLine();
        }
    }
}
