using System;

namespace CallingMethods.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                MathOperations mathOperations = new MathOperations();

                int resultAdd = mathOperations.Add(userInput);
                int resultSubtract = mathOperations.Subtract(userInput);
                int resultMultiply = mathOperations.Multiply(userInput);

                Console.WriteLine($"Result of addition: {resultAdd}");
                Console.WriteLine($"Result of Subtraction: {resultSubtract}");
                Console.WriteLine($"Result of Multiplication: {resultMultiply}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please Enter a valid integer.");
            }
            Console.ReadLine();
        }
    }
}
