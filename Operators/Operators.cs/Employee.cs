using System;
using System.Collections.Generic;
using System.Text;

namespace Operators.cs
{
    class Employee
    {
        public int ID { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.ID == employee2.ID;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.ID != employee2.ID;
        }
    }
}

