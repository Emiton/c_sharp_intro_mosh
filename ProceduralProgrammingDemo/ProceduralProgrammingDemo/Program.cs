using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralProgrammingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get a name and reverse it
            Console.WriteLine("+++++GET NAME+++++");
            Console.Write("What's your name: ");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine(reversed);

            // Get numbers and make sure they are unique
            Console.WriteLine("+++++GET UNIQUE NUMBERS+++++");
            Console.WriteLine("Type 'Quit' to exit.");
            var numbers = new List<int>();

            while(true)
            {
                Console.Write("Enter a number: ");
                var input = Console.ReadLine();

                if (input == "Quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            Console.WriteLine("Unique numbers:");
            foreach (var number in GetUniqueNumbers(numbers))
                Console.WriteLine(number);
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];

            for(var i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }
            return new string(array);
        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }
            return uniques;
        }
    }
}
