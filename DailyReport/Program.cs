using System;

class DailyReport
{
    static void Main()
    {
        // Basic Write/Read with window staying open until keystroke/input
        Console.WriteLine("The Tech Academy \nStudent Daily Report \nPress enter to continue.");
        Console.ReadLine();

        //Input asks with different data types
        Console.WriteLine("What is your name?");
        string studentName = Console.ReadLine();
        Console.WriteLine("Thanks " + studentName + ".");


        Console.WriteLine("What course are you on?");
        string studentCourse = Console.ReadLine();
        Console.WriteLine(studentCourse + ". Got it.");


        //Needs exception handling for non-number inputs
        Console.WriteLine("What page number?");
        short studentNumber = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(studentNumber + " is a great spot.");

        //I feel like bool.Parse would be something that could be used here, esp if data needed to be flagged somehow, but I'm unsure how to incorporate.
        //Alternative solution for custom output utilizing string, would ideally incorporate a while loop perhaps?
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
        string studentHelp = Console.ReadLine().Trim().ToLower(); //Trim and ToLower to make inputs uniform
        if (studentHelp == "true")
        {
            Console.WriteLine("An instructor would be glad to help, we'll give you a call.");
        } else if (studentHelp == "false")
        {
            Console.WriteLine("Excellent!");
        } else
        {
            Console.WriteLine("Input not recognized.");
        }     
           
        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string studentExperience = Console.ReadLine();
        Console.WriteLine("Thank you for that.");

        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string studentFeedback = Console.ReadLine();
        Console.WriteLine("Any feedback will be read.");


        //Needs exception handling for non-integer inputs
        Console.WriteLine("How many hours did you study today?");
        short studentHours = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(studentHours + " hours, got it.");

        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day! \n \n \n Press any key to close.") ;



        Console.ReadLine();



    }
}






