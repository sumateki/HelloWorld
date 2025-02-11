// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? ");
            var name = Console.ReadLine();
            var today = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {DateTime.Now:d} at {DateTime.Now:t}!");
            
            Console.Write($"{ Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
