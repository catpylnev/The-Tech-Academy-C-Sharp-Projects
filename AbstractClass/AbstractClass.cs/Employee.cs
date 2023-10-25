using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass.cs
{
    public class Employee : Person
    {

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override void SayName()
        {
            Console.WriteLine($"Employee's name: {FirstName} {LastName}");
        }
    }
}
