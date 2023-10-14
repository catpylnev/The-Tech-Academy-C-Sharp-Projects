using System;

namespace DailyReport.cs
{
    class program
    {
        static void Main()
        {
            //Title
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            //Questions
            Console.Write("What is your name?");
            string studentName = Console.ReadLine();

            Console.Write("What course are you on?");
            string courseName = Console.ReadLine();

            Console.Write("What page number?");
            int pageNumber = int.Parse(Console.ReadLine());

            Console.Write("Do you need help with anything?");
            string needHelp = Console.ReadLine();

            Console.Write("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            Console.Write("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.Write("How many hours did you study today?");
            double studyHours = double.Parse(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}
