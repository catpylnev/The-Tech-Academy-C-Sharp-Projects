using System;

namespace UsingEnums.cs
{
    class Program
    {
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the current day of the week: ");
                string userInput = Console.ReadLine();
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, ignoreCase: true);
                Console.WriteLine("You entered: " + currentDay);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }
    }
}
