using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // Indexof()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index: " + index);

            // Clear()
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Clear the beginning of the array");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }


            // Copy()
            var anotherArray = new int[3];
            Array.Copy(numbers, anotherArray, 3);

            Console.WriteLine("Copied Array");
            foreach (var n in anotherArray)
            {
                Console.WriteLine(n);
            }

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("Sorted array");

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Reverse the array");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

        }
    }
}
