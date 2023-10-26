using System;
using System.Collections.Generic;
using System.Text;

namespace Operators.cs
{
    class Employee
    {
        public int ID { get; set; }
  
        public override bool Equals(object obj)
        {
            if (obj is Employee otherEmployee)
            {
                return this.ID == otherEmployee.ID;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}
