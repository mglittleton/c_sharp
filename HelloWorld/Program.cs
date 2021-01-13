using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Hello World";

            ConsoleColor color = Console.BackgroundColor;

            Console.ReadKey();

            Console.WriteLine(color);
        }
    }
}
