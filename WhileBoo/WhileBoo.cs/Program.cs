using System;

namespace WhileBoo.cs
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of apples: ");
            int apples = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of oranges: ");
            int oranges = int.Parse(Console.ReadLine());

            Console.WriteLine("Using a do-while statement:");
            do
            {
                Console.WriteLine("I have " + oranges + " oranges.");
                oranges++;
            } while (oranges <= apples);

            Console.WriteLine("Using a while statement:");
            while (apples > 0)
            {
                Console.WriteLine("I have " + apples + " apples.");
                apples--;
            }
        }
    }
}
