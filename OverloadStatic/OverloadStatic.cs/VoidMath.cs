using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadStatic.cs
{
    public class VoidMath
    {
        public void DivideByTwo(int number)
        {
            int result = number / 2;
            Console.WriteLine($"Result of division by 2: {result}");
        }

        public void DivideByTwoWithOutput(int number,out int result)
        {
            result = number / 2;
        }

        public void DivideByTwoWithOutput(int number, out double result)
        {
            result = number / 2.0;
        }
    }
    public static class StaticClass
    {
        public static void DisplayMessage()
        {
            Console.WriteLine("Hello, World");
        }
    }
}
