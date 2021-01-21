using System;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    public enum ShippingMethods
    {
        Regular = 1,
        Registered = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethods.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethods)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethods)Enum.Parse(typeof(ShippingMethods), methodName);
            Console.WriteLine(shippingMethod);
        }


        // ----- Intro to array structures -----
        //static void Main(string[] args)
        //{
        //    var numbers = new int[3];
        //    numbers[0] = 1;

        //    Console.WriteLine(numbers[0]);
        //    Console.WriteLine(numbers[1]);
        //    Console.WriteLine(numbers[2]);

        //    var flags = new bool[3];
        //    flags[0] = true;

        //    Console.WriteLine(flags[0]);
        //    Console.WriteLine(flags[1]);
        //    Console.WriteLine(flags[2]);

        //    var names = new string[3] { "Jack", "John", "Mary" };
        //}



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
