using System;
using System.Collections.Generic;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Initialize an array of strings
            string[] stringArray = new string[] {"Chocolate", "Vanilla", "Strawberry"};

            while (true) // Part 2: Infinite Loop
            {
                // Part 1: Display the strings in the array
                Console.WriteLine("Strings in the array:");
                foreach (string str in stringArray)
                {
                    Console.WriteLine(str);
                }

                // Part 1: Allow the user to enter additional text for each string
                for (int i = 0; i < stringArray.Length; i++) //Part 3: iterating the loop is a  “<” operator
                {
                    Console.Write("Enter additional text for string " + (i + 1) + ": ");
                    string additionalText = Console.ReadLine();
                    stringArray[i] += additionalText;
                }
                //Part 3: iterating the loop is a  “<” operator
                Console.WriteLine("\nNow, using the '<=' operator:");
                for (int i = 0; i <= stringArray.Length - 1; i++)
                {
                    Console.Write("Enter additional text for string " + (i + 1) + ": ");
                    string additionalText = Console.ReadLine();
                    stringArray[i] += additionalText;
                }

                // Part 1: Display the modified strings in the array
                Console.WriteLine("\nModified strings in the array:");
                foreach (string str in stringArray)
                {
                    Console.WriteLine(str);
                }

                // Part 4: Initialize a list of unique strings
                List<string> uniqueStrings = new List<string> { "Apple", "Banana", "Cherry", "Date", "Orange" };

                Console.Write("Enter text to search in the list: "); //Part 4: ask user to input text to search for in list
                string searchText = Console.ReadLine();

                bool found = false;

                // Part 4: Search for the text in the list
                for (int i = 0; i < uniqueStrings.Count; i++)
                {
                    if (uniqueStrings[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Match found at index " + i); // Part 4 displays index when found
                        found = true;
                        break; // Exit the loop once a match is found
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Text not found in the list."); //tells you if text isnt on list
                }

                // Part 5: Initialize a list of animal names
                List<string> animalList = new List<string> { "Cat", "Dog", "Parrot", "Rat", "Cat" };

                Console.Write("Enter text to search in the animal list with duplicates: "); //Part 5 asks user to select animal on lsist
                string animalText = Console.ReadLine();

                bool found2 = false;

                Console.WriteLine("Matching indices in the list:");

                for (int i = 0; i < animalList.Count; i++) // Part 5.2
                {
                    if (animalList[i].Equals(animalText, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Match found at index " + i);
                        found2 = true;
                    }
                }

                if (!found2) //Part 5.3
                {
                    Console.WriteLine("Text not found in the list.");
                }

                // Part 2: Ask if the user wants to continue
                Console.Write("Do you want to continue? (Type 'exit' to quit): ");
                string userInput = Console.ReadLine();

                if (userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break; // Part 2: Exit the infinite loop
                }
            }
        }
    }
}
