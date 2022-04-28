using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------------------------------------------------------
            //Part 1 - One dimensional array of strings w. user input appended to each.
            //Instantiating the array 
            string[] firstArray =
            {
                "Monday's dinner is ",
                "Tuesdays's dinner is ",
                "Wednesdays's dinner is ",
                "And also every day after that we eat ",
            };

            //Asking for user input
            Console.WriteLine("Part One:\nWhat is your favorite food?");
            string inputFood = Console.ReadLine();
            //Added a second var to concatenate a period at the end. 
            //How do I do this off the initial get from the ReadLine?
            string faveFood = inputFood += ".";

            //Looping through array and adding text
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] += faveFood;
                Console.WriteLine(firstArray[i]);
            }
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();


            //---------------------------------------------------------------------------------------------
            //Part 2 - An infinite loop and how to fix it..
            Console.WriteLine("\n\n\nPart Two:");
            int infLoop = 0;
            while (true)
            {
                //This would continue to count up until integer limit is hit (close enough to infinite?)
                Console.WriteLine($"This goes up without a break statement = {infLoop}");
                infLoop++;

                //Adding break statement to stop once conditions met
                if (infLoop > 5)
                {
                    break;
                }
            }
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();


            //---------------------------------------------------------------------------------------------
            //Part 3 - More loops, one with a < condition and one with a  <= condition
            //Looping until < is met
            Console.WriteLine("\n\n\nPart Three:");
            int a = 6;
            while (true)
            {
                Console.WriteLine($"This goes down until it's less than 3 and breaks: {a}");
                a--;

                if (a < 3)
                {
                    break;
                }
            }

            //Looping until <= is met
            int b = 6;
            while (true)
            {
                Console.WriteLine($"This goes down until it's less than or equal to 3 and breaks: {b}");
                b--;

                if (b <= 3)
                {
                    break;
                }
            }
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();


            //---------------------------------------------------------------------------------------------
            //Part Four - List of strings with user input to search and error handling if not found
            List<string> foods = new List<string>()
            {
                "apple","apricot","banana","carrot","chocolate","Doritos","dragonfruit","egg"
            };

            Console.WriteLine("\n\n\nPart Four: \nGuess a food on the list. Suggestions include 'apple' or 'egg.'");
            string foodChoice = Console.ReadLine();
            bool cont = false;
            bool cont2 = false;

            //Utilizing a while statement to allow looping in case input is not found in list
            while (!cont2)
            {
                //Using for statement to get a variable that counts with each iteration
                //Using this to pull an index rather than FindIndex which wouldn't work for duplicates
                for (int i = 0; i < foods.Count; i++)
                {
                    if (foodChoice == foods[i])
                    {
                        Console.WriteLine($"Here's {foods[i]} found at index " + i + ".");
                        cont = true;
                    }
                }
                if (!cont)
                {
                    Console.WriteLine("Try something else.");
                    Console.WriteLine("Choose a food:");
                    foodChoice = Console.ReadLine();
                }
                else
                {
                    cont2 = true;
                }
            }
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();


            //---------------------------------------------------------------------------------------------
            //Part Five - Same as PArt Four but includes duplicate entries
            List<string> foods2 = new List<string>()
            {
                "apple", "apple","apricot","banana","carrot","chocolate","Doritos","dragonfruit","egg", "egg"
            };

            Console.WriteLine("\n\n\nPart Five: \nGuess a food on the list. Duplicates are 'apple' or 'egg.'");
            string foodChoice2 = Console.ReadLine();
            bool cont3 = false;
            bool cont4 = false;

            //Utilizing a while statement to allow looping in case input is not found in list
            while (!cont4)
            {
                //Using for statement to get a variable that counts with each iteration
                //Using this to pull an index rather than FindIndex which wouldn't work for duplicates
                for (int j = 0; j < foods2.Count; j++)
                {
                    if (foodChoice2 == foods2[j])
                    {
                        Console.WriteLine($"Here's {foods2[j]} found at index " + j + ".");
                        cont3 = true;
                    }
                }
                if (!cont3)
                {
                    Console.WriteLine("Try something else.");
                    Console.WriteLine("Choose a food:");
                    foodChoice2 = Console.ReadLine();
                }
                else
                {
                    cont4 = true;
                }
            }
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();


            //---------------------------------------------------------------------------------------------
            //Part Six - Iterate through a list and print to console whether an entry is a duplicate or not
            List<string> foods3 = new List<string>()
            {
                "apple","apricot","apricot","banana","carrot","chocolate","Doritos","dragonfruit","egg","egg"
            };
            //A second empty list needs to be instantiated 
            List<string> dupeFoods = new List<string>();

            Console.WriteLine("Part Six: \nThe following is identifying duplicates on the foods list.");


            //Foreach loop iterating through the original list, adding entries to the second list            
            foreach (string food in foods3)
            {
                //Nested foreach that loops through first list and compares entries to the second, if a match is found, returns to the parent foreach and continues
                bool cont5 = false;
                foreach (string dupeFood in dupeFoods)
                {
                    if (dupeFood == food)
                    {
                        Console.WriteLine($"{dupeFood} is a duplicate entry.");
                        cont5 = true;
                    }

                }
                if (!cont5)
                {
                    dupeFoods.Add(food);
                    Console.WriteLine(food);
                }
            }
            Console.WriteLine("We're done here. Thanks. Press enter to close.");
            Console.ReadLine();
        }
    }
}
