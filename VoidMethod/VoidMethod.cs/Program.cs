using System;

namespace VoidMethod.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Math3 mathCalculator = new Math3();

            int num1 = 5;
            int num2 = 10;

            mathCalculator.PerformMathOperationAndDisplay(num1, num2);
            mathCalculator.PerformMathOperationAndDisplay(number1: 7, number2: 15);

            Console.ReadLine();
        }
    }
}
