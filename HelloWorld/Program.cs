using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 45;
            int sum = num1 + num2;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum + '.');


            Console.Read();
        }
    }
}
