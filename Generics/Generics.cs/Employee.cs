using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.cs
{
    class Employee<T>
    {
        public List<T> Things { get; set; } = new List<T>();
    }
}
