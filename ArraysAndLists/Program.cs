using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        //Array Fundamentals
        //instantiating a new array with an array length of five values
        int[] numArray = new int[5];
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 200;
        numArray[4] = 5000;

        //another way, same as above
        int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //Once length is set, it's set

        //another way, same as above
        int[] numArray2 = { 5, 2, 10, 200, 5000 };

        //to change a value
        numArray2[4] = 650;

        Console.WriteLine(numArray[3] + " " + numArray1[3] + " " + numArray2[3]);
        Console.ReadLine();

        //List Fundamentals
        //Do not need to declare a length
        List<int> intList = new List<int>();
        //Adding
        intList.Add(4);
        intList.Add(10);
        //Removing
        intList.Remove(10);

        //Use arrays to store large quantities of things, ie images to database
        byte[] byteArray = [];



    }
}

