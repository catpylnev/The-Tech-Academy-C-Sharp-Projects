using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.cs
{
    public class Employee : Person
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine($"Employee Name: {FirstName} {LastName}");
        }
    }
}
