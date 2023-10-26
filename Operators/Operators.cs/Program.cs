using System;

namespace Operators.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee { ID = 1 };
            Employee employee2 = new Employee { ID = 2 }; //change IDs here

            bool areEqual = employee1.Equals(employee2);

            Console.WriteLine($"Are employee1 and employee2 equal? {areEqual}");
        }
    }
}
