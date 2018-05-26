using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndListsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mimic Facebook 'likes' system
            var peopleWhoLiked = new List<String>();
            String input;

            while (true)
            {
                Console.Write("Enter name of user who liked post: ");
                input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                else
                {
                    peopleWhoLiked.Add(input);
                }
            }

            if (peopleWhoLiked.Count == 1)
            {
                Console.WriteLine("{0} likes your post", peopleWhoLiked[0]);
            }
            else if (peopleWhoLiked.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post", peopleWhoLiked[0], peopleWhoLiked[1]);
            }
            else if (peopleWhoLiked.Count > 2)
            {
                Console.WriteLine("{0}, {1} and {2} others like your post", peopleWhoLiked[0], peopleWhoLiked[1], peopleWhoLiked.Count - 2);
            }


            // Take name input from user and reverse the name
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            var nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            var reversedName = new string(nameArray);
            Console.WriteLine("Reversed name: " + reversedName);

            // Ask user for 5 unique numbers
            var numberList = new List<int>();
            var count = 0;

            while (count < 5)
            {
                Console.Write("Please enter a unique number: ");
                var currentNumber = Convert.ToInt32(Console.ReadLine());

                if (numberList.Contains(currentNumber))
                {
                    Console.WriteLine("You cannot enter repeating values");
                    count = 6;
                }
                else
                {
                    numberList.Add(currentNumber);
                    count++;
                }
            }

            if(count == 5)
            {
                numberList.Sort();
                Console.WriteLine("Sorted list:");
                
                foreach (var n in numberList)
                {
                    Console.WriteLine(n);
                }
            }


            // User must enter numbers or type "Quit" to exit
            while (true)
            {
                Console.Write("Enter a number: ");
                var userInput = Console.ReadLine();
                var isNumeric = int.TryParse(userInput, out int n);

                if (userInput == "Quit")
                {
                    Console.WriteLine("Whatever you say boss.");
                    break;
                }
                else if (!isNumeric)
                {
                    Console.WriteLine("Numbers buddy! Numbers!!!!");
                }
            }


            // Ask for comma separated values, print the 3 smallest numbers
            Console.Write("Please enter at least 5 numbers separated by commas: ");
            var userCSV = Console.ReadLine();
            string[] numArray = userCSV.Split(',');

            if (numArray.Length >= 5)
            {
                Array.Sort(numArray);
                Console.WriteLine("The three smallest values are {0}, {1}, {2}", numArray[0], numArray[1], numArray[2]);
            }
            else
            {
                Console.WriteLine("Invalid list");
            }


        }
    }
}
