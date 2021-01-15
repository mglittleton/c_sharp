using System;

// non-primative data

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

// type conversions

/*namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            *//*int x = 2000;
            byte output = (byte) x; // output 208 => 1101 0000 that's left after truncation*/

            /*var x = "2000";
            int output = Convert.ToInt32(x); // output 2000 => converted from "2000"*/

            /*var num = "2000";
            byte output = Convert.ToByte(num); // unhandled exception => 2000 is too large for a byte*//*

            try
            {
                var num = "2000";
                byte output = Convert.ToByte(num); // unhandled exception => 2000 is too large for a byte
                Console.WriteLine(output);
            }
            catch (Exception)
            {

                Console.WriteLine("The number could not be converted");
            } // output is the catch 


        }
    }
}*/

// playing with variables

/*namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte number = 2;
            //int count = 10;
            //float totalPrice = 20.95f;
            //char character = 'a';
            //string firstName = "Teddy";
            //bool isWorking = false;

            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'a';
            var firstName = "Teddy";
            var isWorking = false;


            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
        }
    }
}*/
