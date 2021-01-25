using System;
using System.Collections.Generic;
using System.Threading;

namespace Iterables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lists - generic adding/creating

            var numbers = new List<int>() { 1, 1, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            System.Console.WriteLine("Numbers after adding: ");
            foreach (var num in numbers)
                Console.WriteLine(num);

            // Indexing
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));

            // Count
            System.Console.WriteLine("Count: " + numbers.Count);

            // Removing one item
            // numbers.Remove(1);
            // System.Console.WriteLine("Numbers after removing 1: ");
            // foreach (var num in numbers)
            //     Console.WriteLine(num);

            // Removing all instances
            System.Console.WriteLine("Numbers after removing all 1s: ");
            var count = 0;
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    count++;
                }
            }
            for (var i = 0; i < count; i++)
            {
                numbers.Remove(1);
            }
            foreach (var num in numbers)
                Console.WriteLine(num);
            System.Console.WriteLine("Count after removals: " + numbers.Count);


            // Arrays - generic
            //     // Length
            //     var numbers = new[] { 3, 7, 9, 2, 14, 6 };
            //     Console.WriteLine("length: " + numbers.Length);

            //     // IndexOf()
            //     var index = Array.IndexOf(numbers, 9);
            //     Console.WriteLine("index of 9: " + index);

            //     // Clear
            //     Array.Clear(numbers, 0, 2);
            //     Console.WriteLine("Effect of Clear:");
            //     foreach (var n in numbers)
            //         Console.WriteLine(n);

            //     // Copy
            //     int[] another = new int[3];
            //     Array.Copy(numbers, another, 3);
            //     Console.WriteLine("Effect of Copy:");
            //     foreach (var n in another)
            //         Console.WriteLine(n);

            //     // Sort
            //     Array.Sort(numbers);
            //     Console.WriteLine("Effect of Sort:");
            //     foreach (var n in numbers)
            //         Console.WriteLine(n);

            //     // Reverse
            //     Array.Reverse(numbers);
            //     Console.WriteLine("Effect of Reverse:");
            //     foreach (var n in numbers)
            //         Console.WriteLine(n);

            //     // IsFixedSize
            //     bool fixd = numbers.IsFixedSize;
            //     Console.WriteLine("Is a fixed size:");
            //     Console.WriteLine(fixd);

            Console.WriteLine("Hit enter to end...");
            Console.Read();
        }
    }
}
