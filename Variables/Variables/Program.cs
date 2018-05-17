// Section 3 Lecture 17 Demo 
// Primitive Types: Variables and Constants

using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Play with C# data types
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Emiton";
            var isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            

           // Learn how to input variables into a Console.WriteLine string
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            
            // Use a constant
            const float Pi = 3.14f;
        }
    }
}
