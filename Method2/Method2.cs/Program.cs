using System;

namespace Method2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Math mathCalculator = new Math();

            Console.Write("Enter the first number: ");
            if (int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.Write("Enter the second number (or press enter to skip): ");
                if (int.TryParse(Console.ReadLine(), out int num2))
                {
                    int result = mathCalculator.PerformMathOperation(num1, num2);
                    Console.WriteLine($"Result of subtraction: {result}");
                }
                else
                {
                    int result = mathCalculator.PerformMathOperation(num1);
                    Console.WriteLine($"Result of subtraction with one number: {result}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
            Console.ReadLine();

        }
    }
}
