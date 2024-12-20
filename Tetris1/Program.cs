// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, Wordfsdfld!");

using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Asking for user input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Displaying a personalized message
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
