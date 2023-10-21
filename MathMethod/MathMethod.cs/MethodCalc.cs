using System;

public class MathCalculator
{
    public int PerformMathOperation(int number)
    {
        return number + 47;
    }

    public int PerformMathOperation(decimal number)
    {
        return (int)(number * 366);
    }

    public int PerformMathOperation(string input)
    {
        if (int.TryParse(input, out int parsedNumber))
        {
            return parsedNumber - 2;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return 0;
        }
    }
}
