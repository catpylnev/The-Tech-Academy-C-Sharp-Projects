using System;
using System.Collections.Generic;
using System.Linq;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[3];

            while (true)
            {
                Console.Write("Enter text for string 1 (type 'exit' to quit): ");
                string userInput = Console.ReadLine();

                if (userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                stringArray[0] = userInput;

                for (int i = 1; i < stringArray.Length; i++)
                {
                    Console.Write("Enter text for string " + (i + 1) + ": ");
                    string additionalText = Console.ReadLine();
                    stringArray[i] = additionalText;
                }

                Console.WriteLine("Strings in the array:");
                foreach (string str in stringArray)
                {
                    Console.WriteLine(str);
                }

                for (int i = 0; i <= stringArray.Length - 1; i++)
                {
                    Console.Write("Enter additional text for string " + (i + 1) + ": ");
                    string additionalText = Console.ReadLine();
                    stringArray[i] += additionalText;
                }

                Console.WriteLine("\nModified strings in the array:");
                foreach (string str in stringArray)
                {
                    Console.WriteLine(str);
                }

                List<string> uniqueStrings = new List<string>
                {
                    "Apple", "Banana", "Cherry", "Date", "Orange"
                };

                uniqueStrings.Add("Banana");
                uniqueStrings.Add("Date");

                Console.Write("Enter text to search in the list: ");
                string searchText = Console.ReadLine();

                bool found = false;

                for (int i = 0; i < uniqueStrings.Count; i++)
                {
                    if (uniqueStrings[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Match found at index " + i);
                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Text not found in the list.");
                }

                List<string> animalList = new List<string>
                {
                    "Cat", "Dog", "Parrot", "Rat", "Cat"
                };


                HashSet<string> seenStrings = new HashSet<string>();

                Console.WriteLine("\nChecking for duplicates in animalList:");

                foreach (string str in animalList)
                {
                    if (seenStrings.Contains(str))
                    {
                        continue;
                    }

                    int count = animalList.Count(s => s.Equals(str, StringComparison.OrdinalIgnoreCase));

                    if (count > 1)
                    {
                        Console.WriteLine($"{str} has appeared {count} times in the list.");
                    }
                    else
                    {
                        Console.WriteLine($"{str} is unique in the list.");
                    }

                    seenStrings.Add(str);
                }
            }
        }
        
    }
}