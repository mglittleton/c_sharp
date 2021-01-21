using System;

namespace Conditionals
{
  class Program
  {
    public static void Exercise1()
    {
      Console.WriteLine("Please enter a number between 1 and 10:");
      int entry = Int32.Parse(Console.ReadLine());

      if (1 <= entry && entry <= 10)
      {
        Console.WriteLine("Valid");
      }
      else
      {
        Console.WriteLine("Invalid");
      }
    }

    public static void Exercise2()
    {
      Console.WriteLine("Please enter number 1:");
      int entA = Int32.Parse(Console.ReadLine());
      Console.WriteLine("Please enter number 2:");
      int entB = Int32.Parse(Console.ReadLine());

      if (entA > entB)
      {
        Console.WriteLine(string.Format("{0} is greater than {1}", entA, entB));
      }
      else if (entA == entB)
      {
        Console.WriteLine(string.Format("{0} is equal to {1}", entA, entB));
      }
      else
      {
        Console.WriteLine(string.Format("{1} is greater than {0}", entA, entB));
      }
    }
    public static void Main(string[] args)
    {
      Exercise2();

      // ----- Switch case -----
      // var season = Season.Autumn;

      // switch (season)
      // {
      //   case Season.Autumn: // with no "break" command, the case is spilled into the next and functions like a OR statement
      //   case Season.Winter:
      //     Console.WriteLine("We've got a promotion.");
      //     break;
      //   case Season.Summer:
      //     Console.WriteLine("It's summer and very humid.");
      //     break;
      //   case Season.Spring:
      //     Console.WriteLine("It's spring and the birds are singing.");
      //     break;
      //   default:
      //     Console.WriteLine("I don't understand");
      //     break;
      // }

      // ----- Standard style of if/else -----
      // bool isGoldCustomer = true;
      // float price;
      // if (isGoldCustomer)
      // {
      //   price = 19.95f;
      // }
      // else
      // {
      //   price = 29.95f;
      // }


      // ----- ternary style of if/else -----
      // bool isGoldCustomer = true;
      // float price = (isGoldCustomer) ? 19.95f : 29.95f;

      // Console.WriteLine(price);


      // ----- basic if/else -----
      // int hour = 10;

      // if (hour > 0 && hour < 12)
      // {
      //   Console.WriteLine("It's morning.");
      // }
      // else if (hour >= 12 && hour < 18)
      // {
      //   Console.WriteLine("It's afternoon.");
      // }
      // else
      // {
      //   Console.WriteLine("It's night.");
      // }

    }
  }
}
