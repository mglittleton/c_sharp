using System;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

        }



        // ----- Intro to class structures -----
        //static void Main(string[] args)
        //{
        //    var john = new Person();
        //    john.FirstName = "John";
        //    john.LastName = "Smith";
        //    john.Introduce();

        //    Calculator calculator = new Calculator();
        //    var result = calculator.Add(1, 2);
        //    Console.WriteLine(result);
        //}
    }
}
