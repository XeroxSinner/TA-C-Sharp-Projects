using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProperIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> foods = new List<string>()
            {
                "apple","apricot","apricot","banana","carrot","chocolate","Doritos","dragonfruit","egg","egg"
            };       
            
            
            Console.WriteLine("Choose a food:");

            string foodChoice = Console.ReadLine();
            bool cont = false;
            bool cont2 = false;

            while (!cont2)
            {
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



            //bool cont = false;


            //while (!cont)
            //{
            //    string userLetter = Console.ReadLine();
            //    for (int i = 0; i < foods.Count; i++)
            //    {

            //        if (foods[i].StartsWith(userLetter, StringComparison.OrdinalIgnoreCase))
            //        {
            //            Console.WriteLine($"Here's {foods[i]}, found at index " + i);
            //            cont = true;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Try again.");
            //        }
            //    }
            //}
            Console.ReadLine();
        }
    }
}

//create a counter that increments each iteration - 

//Utilizing do/while though this feels like there's a better way..
//do
//{
//    string userLetter = Console.ReadLine();
//    switch (userLetter)
//    {
//        case "a":
//            foreach (string food in foods)
//                if (food.StartsWith(userLetter, StringComparison.OrdinalIgnoreCase))
//                {
//                    int foodIndex = foods.FindIndex(f => f.Equals(food));
//                    Console.WriteLine($"Here's {food}, found at index " + foodIndex);
//                }
//            cont = true;
//            Console.WriteLine("Press enter to continue...");
//            break;

//        case "b":
//            foreach (string food in foods)
//                if (food.StartsWith(userLetter, StringComparison.OrdinalIgnoreCase))
//                {
//                    int foodIndex = foods.FindIndex(f => f.Equals(food));
//                    Console.WriteLine($"Here's {food}, found at index " + foodIndex);
//                }
//            cont = true;
//            Console.WriteLine("Press enter to continue...");
//            break;

//        case "c":
//            foreach (string food in foods)
//                if (food.StartsWith(userLetter, StringComparison.OrdinalIgnoreCase))
//                {
//                    int foodIndex = foods.FindIndex(f => f.Equals(food));
//                    Console.WriteLine($"Here's {food}, found at index " + foodIndex);
//                }
//            cont = true;
//            Console.WriteLine("Press enter to continue...");
//            break;

//        case "d":
//            foreach (string food in foods)
//                if (food.StartsWith(userLetter, StringComparison.OrdinalIgnoreCase))
//                {
//                    int foodIndex = foods.FindIndex(f => f.Equals(food));
//                    Console.WriteLine($"Here's {food}, found at index " + foodIndex);
//                }
//            cont = true;
//            Console.WriteLine("Press enter to continue...");
//            break;

//        case "e":
//            foreach (string food in foods)
//                if (food.StartsWith(userLetter, StringComparison.OrdinalIgnoreCase))
//                {
//                    int foodIndex = foods.FindIndex(f => f.Equals(food));
//                    Console.WriteLine($"Here's {food}, found at index " + foodIndex);
//                }
//            cont = true;
//            Console.WriteLine("Press enter to continue...");
//            break;

//        default:
//            Console.WriteLine("Not found. Try again.");
//            break;
//    }
//}
//while (!cont);
//Console.Read();

////Notes from original thought, couldn't figure out "Not found" logic..
////My issues with the code below is that for every list entry it will print either the if or the else, whereas the clunky switch above does not
////while (!cont)
////{
////    string userLetter = Console.ReadLine();
////    foreach (string food in foods)
////    {
////        if (food.StartsWith(userLetter, StringComparison.OrdinalIgnoreCase))
////        {
////            int foodIndex = foods.FindIndex(f => f.Equals(food));
////            Console.WriteLine($"Here's {food}, found at index " + foodIndex);
////            cont = true;
////        }
////        else
////        {
////            Console.WriteLine("Invalid, nothing there, try again.");
////        }
////    }

////---------------------------------------------------------------------------------------------
////Part Five - List of strings with user input to search and error handling if not found
////There are two items "egg" - the following code will not hangup on the index of the first one

//Console.WriteLine("\n\n\nPart Five: \nInput a letter again. Preferably 'e' to show proper counting of indexes with duplicate entries.");
//bool cont1 = false;

////Utilizing do/while though this feels like there's a better way.. same code as part four with fix for index count
//do
//{
//    string userLetter = Console.ReadLine();
//    switch (userLetter)
//    {
//        case "a":
//            foreach (string food in foods)
//                if (food.StartsWith(userLetter, StringComparison.OrdinalIgnoreCase))
//                {
//                    int foodIndex = foods.FindIndex(f => f.Equals(food));
//                    Console.WriteLine($"Here's {food}, found at index " + foodIndex);
//                }
//            cont1 = true;
//            Console.WriteLine("Press enter to continue...");
//            break;

//        case "b":
//            foreach (string food in foods)
//                if (food.StartsWith(userLetter, StringComparison.OrdinalIgnoreCase))
//                {
//                    int foodIndex = foods.FindIndex(f => f.Equals(food));
//                    Console.WriteLine($"Here's {food}, found at index " + foodIndex);
//                }
//            cont1 = true;
//            Console.WriteLine("Press enter to continue...");
//            break;

//        case "c":
//            foreach (string food in foods)
//                if (food.StartsWith(userLetter, StringComparison.OrdinalIgnoreCase))
//                {
//                    int foodIndex = foods.FindIndex(f => f.Equals(food));
//                    Console.WriteLine($"Here's {food}, found at index " + foodIndex);
//                }
//            cont1 = true;
//            Console.WriteLine("Press enter to continue...");
//            break;

//        case "d":
//            foreach (string food in foods)
//                if (food.StartsWith(userLetter, StringComparison.OrdinalIgnoreCase))
//                {
//                    int foodIndex = foods.FindIndex(f => f.Equals(food));
//                    Console.WriteLine($"Here's {food}, found at index " + foodIndex);
//                }
//            cont1 = true;
//            Console.WriteLine("Press enter to continue...");
//            break;

//        case "e":
//            foreach (string food in foods)
//                if (food.StartsWith(userLetter, StringComparison.OrdinalIgnoreCase))
//                {
//                    int foodIndex = foods.FindIndex(f => f.Equals(food));
//                    Console.WriteLine($"Here's {food}, found at index " + foodIndex);
//                }
//            cont1 = true;
//            Console.WriteLine("Press enter to continue...");
//            break;

//        default:
//            Console.WriteLine("Not found. Try again.");
//            break;
//    }
//}
//while (!cont1);
//Console.Read();


