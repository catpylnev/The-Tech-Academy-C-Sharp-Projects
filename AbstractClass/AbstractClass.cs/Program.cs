using System;

namespace AbstractClass.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Sample", "Student");

            
                employee.SayName();
                //employee.Quit();
                IQuittable quittableEmployee = employee;
                quittableEmployee.Quit();
                Console.ReadLine();
            
        }
    }
}
