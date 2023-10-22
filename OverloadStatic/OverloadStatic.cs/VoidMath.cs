using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadStatic.cs
{
    public class VoidMath
    {
        public static void DivideByThree(int number)
        {
            int result = number / 3;
            Console.WriteLine($"Result of division by 3: {result}");
        }

        public static void DivideByThreeWithOutput(int number,out int result)
        {
            result = number / 3;
        }

        public static void DivideByThreeWithOutput(int number, out double result)
        {
            result = number / 3.0;
        }
    }
}
