using System;

namespace Insurance.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? (True/False)");
            bool hasDUI = bool.Parse(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = int.Parse(Console.ReadLine());

            bool isQualified = (age > 15) && (!hasDUI) && (speedingTickets <= 3);

            string qualifiedResult = isQualified ? "Yes" : "No";

            Console.WriteLine("Qualified? " + qualifiedResult);

            Console.ReadLine();
        }
    }
}
