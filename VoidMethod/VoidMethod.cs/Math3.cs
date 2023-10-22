using System;
using System.Collections.Generic;
using System.Text;

namespace VoidMethod.cs
{
    public class Math3
    {
        public void PerformMathOperationAndDisplay(int number1, int number2)
        {
            int result = number1 * 2;

            Console.WriteLine($"Result of the main operation on the first integer: {result}");
            Console.WriteLine($"Second integer: {number2}");
        }
    }
}
