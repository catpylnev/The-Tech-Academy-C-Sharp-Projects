using System;

namespace OverloadStatic.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // VoidMath math = new VoidMath();

            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int userNumber))
            {
                VoidMath.DivideByThree(userNumber);

                int output;
                VoidMath.DivideByThreeWithOutput(userNumber, out output);
                Console.WriteLine($"Output with output parameter: {output}");

                double doubleOutput;
                VoidMath.DivideByThreeWithOutput(userNumber, out doubleOutput);
                Console.WriteLine($"Double output: {doubleOutput}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            Console.ReadLine();
        }
    }
}
