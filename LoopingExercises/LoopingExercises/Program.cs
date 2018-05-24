using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find how many numbers between 0 - 100 are divisble by 3 and write to console
            int count = 0;
            for(int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Numbers divisble by 3 --> " + count);

            // Ask user to enter values, sum values, end program when user enters ok
            int sum = 0;
            var isDone = false;

            while (!isDone)
            {
                Console.Write("Enter a value: ");
                var input = Console.ReadLine();

                if (input == "OK" || input == "Ok" || input == "ok")
                {
                    isDone = true;
                }
                else
                {
                    sum += Int32.Parse(input);
                }
            }
            Console.WriteLine(sum);

            // Compute the factorial of user input
            ulong total = 1;
            Console.Write("Enter your factorial: ");
            ulong userInput = ulong.Parse(Console.ReadLine());

            for (ulong i = 1; i <= userInput; i++)
            {
                total *= i;
            }
            Console.WriteLine(total);


            // Create a random number, allow user to guess 4 times
            var randyOrton = new Random();
            int randValue = randyOrton.Next(1, 10);
            int j = 0;
            while(j < 4)
            {
                Console.Write("Guess the random value: ");
                int guess = Int32.Parse(Console.ReadLine());

                if (guess == randValue)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else
                    j++;
            }
            if (j == 4)
                Console.WriteLine("You have let down your ancestors! SHAME!");


            // Ask user to enter values separated by comma, find max value
            int maxValue = 0;
            Console.Write("Enter your values separated by commas: ");
            string commaInput = Console.ReadLine();
            var numbers = from val in commaInput.Split(',') select int.Parse(val);



            foreach (var number in numbers)
            {
                if (number > maxValue)
                {
                    maxValue = number;
                }
            }
            Console.WriteLine(maxValue);
        }
    }
}
