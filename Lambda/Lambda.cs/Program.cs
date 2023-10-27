using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda.cs
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set;  }
        public int ID { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { FirstName = "Joe", LastName = "Snow", ID = 1 },
                new Employee { FirstName = "Daenerys", LastName = "Targaryen", ID = 2 },
                new Employee { FirstName = "Tyrion", LastName = "Lannister", ID = 3 },
                new Employee { FirstName = "Arya", LastName = "Stark", ID = 4 },
                new Employee { FirstName = "Cersei", LastName = "Lannister", ID = 5 },
                new Employee { FirstName = "Sansa", LastName = "Stark", ID = 6 },
                new Employee { FirstName = "Joe", LastName = "Stark", ID = 7 },
                new Employee { FirstName = "Jaime", LastName = "Lannister", ID = 8 },
                new Employee { FirstName = "Tormund", LastName = "Giantsbane", ID = 9 },
                new Employee { FirstName = "Brienne", LastName = "of Tarth", ID = 10 }
            };

            List<Employee> joes = new List<Employee>();

            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            Console.WriteLine("Employees with the first name 'Joe' (using a foreach loop):");
            foreach (var joe in joes)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName}");
            }

            Console.WriteLine("Employees with the first name 'Joe' (Lambda expression):");
            var joesLambda = employees.Where(e => e.FirstName == "Joe").ToList();
            joesLambda.ForEach(joe => Console.WriteLine($"{joe.FirstName} {joe.LastName}"));

            Console.WriteLine("\nEmployees with an ID greater than 5 (lambda expression):");
            var highIdEmployees = employees.Where(e => e.ID > 5).ToList();
            highIdEmployees.ForEach(employee => Console.WriteLine($"{employee.FirstName} {employee.LastName} (ID: {employee.ID})"));
        }
    }
    
}
