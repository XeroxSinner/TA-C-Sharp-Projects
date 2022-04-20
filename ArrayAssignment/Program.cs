using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        static void Main()
        {
            //Arrays and Lists defined
            string[] stringArray =
            {
                "Zero index, classy.",
                "Index one, alright.",
                "Here's index value two."
            };

            int[] intArray = { 1, 2, 3, 5, 8 };

            List<string> stringList = new List<string>()
            {
                "A string in the list at index 0.",
                "A string in the list at index 1.",
                "A string in the list at index 2.",
                "A string in the list at index 3."
            };




            //Step 1 - Single input with index value, do/while statement with switches to handle choices and invalid choices
            Console.WriteLine("Here's a one-dimensional array of strings. Pick a number and we'll print what's in that index.");
            bool cont = false;

            do
            {
                int indexChoice = Convert.ToInt32(Console.ReadLine());
                switch (indexChoice)
                {
                    case 0:
                        Console.WriteLine($"Here's {indexChoice}: {stringArray[indexChoice]}. \nPress enter to move on.");
                        cont = true;
                        break;
                    case 1:
                        Console.WriteLine($"Here's {indexChoice}: {stringArray[indexChoice]}. \nPress enter to move on.");
                        cont = true;
                        break;
                    case 2:
                        Console.WriteLine($"Here's {indexChoice}: {stringArray[indexChoice]}. \nPress enter to move on.");
                        cont = true;
                        break;
                    default:
                        Console.WriteLine($"There's no index {indexChoice}, may I suggest 0, 1, or 2? Try one of those now.");
                        break;
                }
            }
            while (!cont);

            Console.ReadLine();

            //Step 2 - Same as step 1 but using integers in the array rather than strings.
            Console.WriteLine("Here's a one-dimensional array of integers. Pick an index value and we'll print what's in that index.");
            bool cont1 = false;

            do
            {
                int indexChoice1 = Convert.ToInt32(Console.ReadLine());
                switch (indexChoice1)
                {
                    case 0:
                        Console.WriteLine($"Here's {indexChoice1}: {intArray[indexChoice1]}. \nPress enter to move on.");
                        cont1 = true;
                        break;
                    case 1:
                        Console.WriteLine($"Here's {indexChoice1}: {intArray[indexChoice1]}. \nPress enter to move on.");
                        cont1 = true;
                        break;
                    case 2:
                        Console.WriteLine($"Here's {indexChoice1}: {intArray[indexChoice1]}. \nPress enter to move on.");
                        cont1 = true;
                        break;
                    case 3:
                        Console.WriteLine($"Here's {indexChoice1}: {intArray[indexChoice1]}. \nPress enter to move on.");
                        cont1 = true;
                        break;
                    case 4:
                        Console.WriteLine($"Here's {indexChoice1}: {intArray[indexChoice1]}. \nPress enter to move on.");
                        cont1 = true;
                        break;
                    default:
                        Console.WriteLine($"There's no index {indexChoice1}, may I suggest 0 through 4? Try one of those now.");
                        break;
                }
            }
            while (!cont1);
            Console.ReadLine();

            //Step 4 - Same as Step 1 and 2, utilizing a list of strings instead.
            Console.WriteLine("Here's a list of strings. Pick an index value and we'll print what's in that index.");
            bool cont2 = false;

            do
            {
                int indexChoice2 = Convert.ToInt32(Console.ReadLine());
                switch (indexChoice2)
                {
                    case 0:
                        Console.WriteLine($"Here's {indexChoice2}: {stringList[indexChoice2]}. \nPress enter to exit.");
                        cont2 = true;
                        break;
                    case 1:
                        Console.WriteLine($"Here's {indexChoice2}: {stringList[indexChoice2]}. \nPress enter to exit.");
                        cont2 = true;
                        break;
                    case 2:
                        Console.WriteLine($"Here's {indexChoice2}: {stringList[indexChoice2]}. \nPress enter to exit.");
                        cont2 = true;
                        break;
                    case 3:
                        Console.WriteLine($"Here's {indexChoice2}: {stringList[indexChoice2]}. \nPress enter to exit.");
                        cont2 = true;
                        break;
                    default:
                        Console.WriteLine($"There's no index {indexChoice2}, may I suggest 0 through 3? Try one of those now.");
                        break;
                }
            }
            while (!cont2);
            Console.Read();


            //if (indexChoice < 3)
            //{
            //    Console.WriteLine($"Here's {indexChoice}: {stringArray[indexChoice]}");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine($"There's no index {indexChoice}, may I suggest 0, 1, or 2? Try one of those now.");
            //}


        }
    }
}
