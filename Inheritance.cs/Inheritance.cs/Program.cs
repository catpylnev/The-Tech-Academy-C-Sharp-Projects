using System;

namespace Inheritance.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                FirstName = "Catherine",
                LastName = "Pylnev",
                Id = 12345
            };

            employee.SayName();

            Console.ReadLine(); 
        }
    }
}
