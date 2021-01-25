﻿using System;
using System.Threading;

namespace Iterables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Length
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };
            Console.WriteLine("length: " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("index of 9: " + index);

            // Clear
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear:");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Copy
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Copy:");
            foreach (var n in another)
                Console.WriteLine(n);
            
            Thread.Sleep(50000);
        }
    }
}
