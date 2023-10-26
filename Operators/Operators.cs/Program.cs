using System;

namespace Operators.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee { ID = 1 };
            Employee employee2 = new Employee { ID = 2 };
            Employee employee3 = new Employee { ID = 1 };

            bool areEqual1 = employee1 == employee2;
            bool areEqual2 = employee1 == employee3;

            Console.WriteLine($"Are employee1 and employee2 equal? {areEqual1}");
            Console.WriteLine($"Are employee1 and employee3 equal? {areEqual2}");
        }
    }
}
