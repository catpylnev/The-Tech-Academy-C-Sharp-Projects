using System;

namespace Comparison.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.Write("Hourly Rate?");
            double hourlyRate1 = double.Parse(Console.ReadLine());

            Console.Write("Hours worked per week?");
            double hoursWorkedPerWeek1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.Write("Hourly Rate?");
            double hourlyRate2 = double.Parse(Console.ReadLine());

            Console.Write("Hours worked per week?");
            double hoursWorkedPerWeek2 = double.Parse(Console.ReadLine());

            double annualSalary1 = hourlyRate1 * hoursWorkedPerWeek1 * 52;
            double annualSalary2 = hourlyRate2 * hoursWorkedPerWeek2 * 52;

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine($"{annualSalary1:N0}");

            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine($"{annualSalary2:N0}");

            bool person1MakesMore = annualSalary1 > annualSalary2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(person1MakesMore);

            Console.ReadLine(); // Pause the program to view the output
        }

    }
}
