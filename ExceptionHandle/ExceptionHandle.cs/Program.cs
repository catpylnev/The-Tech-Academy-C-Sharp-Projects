using System;

namespace ExceptionHandle.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = { 10, 20, 30, 40, 50 };
                Console.Write("Enter a number to divede by: ");
                int divide = int.Parse(Console.ReadLine());

                foreach (int num in numbers)
                {
                    int result = num / divide;
                    Console.WriteLine($"{num} divided by {divide} is {result}");
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Error: {e.Message} You cannot divide by zero.");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Error: {e.Message} Please enter a valid number");
            }

            Console.WriteLine("The program has finished.");
        }
    }
}
