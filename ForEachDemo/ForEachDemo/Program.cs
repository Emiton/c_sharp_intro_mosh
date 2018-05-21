using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print every chracter in a string
            var name = "Luke Skywalker";
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            // Simplify for loop by using foreach
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            // Same concept with int array
            var numbers = new int[] { 1, 2, 3, 4 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
