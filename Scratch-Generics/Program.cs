using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratch_Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee<string> emp1 = new Employee<string>();
            emp1.Things = new List<string>();

            emp1.Things.Add("Thing");
            emp1.Things.Add("Thing2");
            emp1.Things.Add("Thing3");

            Employee<int> emp2 = new Employee<int>
            {
                Things = new List<int>()
            };

            emp2.Things.Add(1);
            emp2.Things.Add(2);
            emp2.Things.Add(3);

            foreach (string str in emp1.Things)
            {
                Console.WriteLine(str);
            }

            foreach (int i in emp2.Things)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
            


        }
    }
}
