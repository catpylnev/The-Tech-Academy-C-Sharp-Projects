using System;
using System.Collections.Generic;

namespace Generics.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeeWithString = new Employee<string>();

            employeeWithString.Things = new List<string>
            {
                "Thing 1",
                "Thing 2",
                "Thing 3"
            };

            Employee<int> employeeWithInt = new Employee<int>();

            employeeWithInt.Things = new List<int>
            {
                1,
                2,
                3,
                4,
                5
            };

            Console.Write("Things of Employee with string type:");
            foreach (string thing in employeeWithString.Things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("\n Things of Employee with int type:");
            foreach(int thing in employeeWithInt.Things)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
