using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartSixIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> foods = new List<string>()
            {
                "apple","apricot","apricot","banana","carrot","chocolate","Doritos","dragonfruit","egg","egg"
            };
            List<string> dupeFoods = new List<string>();

            foreach (string food in foods)
            {
                bool cont = false;
                foreach (string dupeFood in dupeFoods)
                {
                    if (dupeFood == food)
                    {
                        Console.WriteLine($"{dupeFood} is a duplicate entry.");
                        cont = true;
                    }

                }
                if (!cont)
                {
                    dupeFoods.Add(food);
                    Console.WriteLine(food);
                }

            }



            Console.ReadLine();
        }
    }
}


//string[] ss = { "1", "1", "1" };

//var myList = new List<string>();
//var duplicates = new List<string>();

//foreach (var s in ss)
//{
//    if (!myList.Contains(s))
//        myList.Add(s);
//    else
//        duplicates.Add(s);
//}

//// show list without duplicates 
//foreach (var s in myList)
//    Console.WriteLine(s);

//// show duplicates list
//foreach (var s in duplicates)
//    Console.WriteLine(s);