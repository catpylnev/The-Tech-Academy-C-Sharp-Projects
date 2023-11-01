using System;

namespace Datetime.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("Current Date and Time: " + currentTime);

            Console.Write("Enter a number of hours: ");
            if (int.TryParse(Console.ReadLine(), out int hours))
            {
                DateTime futureTime = currentTime.AddHours(hours);
                Console.WriteLine($"Time in {hours} hours will be: {futureTime}");
            }
            else
            {
                Console.WriteLine("Invalid Input. Please enter a valid number of hours.");
            }
        }
    }
}
