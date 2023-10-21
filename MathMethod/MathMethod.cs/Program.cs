using System;

class Program
{
    static void Main(string[] args)
    {
        MathCalculator mathCalculator = new MathCalculator();

        int resultInt = mathCalculator.PerformMathOperation(10);
        Console.WriteLine($"Result of integer operation: {resultInt}");

        int resultDecimal = mathCalculator.PerformMathOperation(5.5m);
        Console.WriteLine($"Result of decimal operation: {resultDecimal}");

        int resultString = mathCalculator.PerformMathOperation("7");
        Console.WriteLine($"Result of string operation: {resultString}");

        Console.ReadLine(); 
    }
}
