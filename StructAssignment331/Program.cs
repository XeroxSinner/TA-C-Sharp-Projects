using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment331
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number num1;
            num1.Amount = 45.25m;

            Console.WriteLine(num1.Amount);
            Console.ReadLine();


        }
    }

    struct Number
    {
        public decimal Amount;
    }
}
