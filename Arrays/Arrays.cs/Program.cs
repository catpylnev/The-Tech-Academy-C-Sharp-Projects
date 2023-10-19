using System;
using System.Collections.Generic;

namespace Arrays.cs
{
    class Program
    {
        static void Main()
        {

            string[] stringArray = { "Cat", "Dog", "Rat", "Bird" };
            int[] intArray = { 10, 20, 30, 40, 50 };
            List<string> stringList = new List<string> ();

            stringList.Add("Alpha");
            stringList.Add("Beta");
            stringList.Add("Gamma");
            stringList.Add("Delta");

            while (true)
            {
                Console.WriteLine("Options:");
                Console.WriteLine("1. Display a string from the string array");
                Console.WriteLine("2. Display an integer from the integer array");
                Console.WriteLine("3. Display a string from the string list");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice (1/2/3/4): ");
                string choice = Console.ReadLine();

                if (choice == "4")
                {
                    Console.WriteLine("Exiting the program.");
                    break;
                }

                Console.Write("Enter the index: ");
                if (int.TryParse(Console.ReadLine(), out int index))
                {
                    if (choice == "1" && index >= 0 && index < stringArray.Length)
                    {
                        Console.WriteLine("Selected string: " + stringArray[index]);
                    }
                    else if (choice == "2" && index >= 0 && index < intArray.Length)
                    {
                        Console.WriteLine("Selected integer: " + intArray[index]);
                    }
                    else if (choice == "3" && index >= 0 && index < stringList.Count)
                    {
                        Console.WriteLine("Selected string: " + stringList[index]);
                    }
                    else
                    {
                        Console.WriteLine("Index doesn't exist.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid index. Please enter a valid number.");
                }
            }
        }

    }
    
}
