using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> foods = new List<string>()
            {
                "apple","apricot","banana","carrot","chocolate","Doritos","dragonfruit","egg","egg"
            };

            Console.WriteLine("\n\n\nPart Four: \nInput a letter. Let's see if I've added a food that starts with that. \n(Hint: a through e will have matches) Which letter?");


            //int i2 = 0;
            //int standing = 0;
            bool cont = false;
            //int index = 0;
            //while (!isValid)
            //{
            //    i2 = 0;
            //    string userLetter = Console.ReadLine();
            //    foreach (string food in foods)
            //    {
            //        if (userLetter == food.Substring(0, 1))
            //        {
            //            standing = i2 + 1;
            //            index = i2;
            //        }
            //        i2++;
            //    }
            //    if (standing == 0)
            //    {
            //        Console.WriteLine("Invalid choice.");
            //    }
            //    else
            //    {
            //        isValid = true;
            //    }
            //}

            //Console.WriteLine("Index is: " + index + " and standing is now: " + standing);



            //Notes from original thought, couldn't figure out "Not found" logic..
            //Foreach that loops through list, and prints list item found and at what index

            while (!cont)
            {
                string userLetter = Console.ReadLine();
                foreach (string food in foods)
                {
                    if (food.StartsWith(userLetter, StringComparison.OrdinalIgnoreCase))
                    {
                        int foodIndex = foods.FindIndex(f => f.Equals(food));
                        Console.WriteLine($"Here's {food}, found at index " + foodIndex);
                        cont = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid, nothing there, try again.");
                    }
                }

                //else
                //{
                //    Console.WriteLine("Invalid. Again. Else");
                //    isValid = true;
                //}
                //if (standing == 0)
                //    {
                //        Console.WriteLine("Invalid. Again.");
                //    }
                //else
                //    {
                //        isValid = true;
                //    }

                //}

            
                //foreach (string food in foods)
                //{
                //    if (!food.StartsWith(userLetter, StringComparison.OrdinalIgnoreCase))
                //    {
                //        Console.WriteLine("Invalid. Try Again.");
                //    }
                //}
            }
            Console.ReadLine();
        }
    }
}
