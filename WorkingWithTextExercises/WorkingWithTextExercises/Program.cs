using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithTextExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check if user input is consecutive
            Console.WriteLine("Enter numbers separated by hypen (e.g. 1-2-3-4):");
            var input = Console.ReadLine();
            if (IsConsectuive(input))
                Console.WriteLine("Consecutive");
            else
                Console.WriteLine("Not Consecutive");

            // Ask user for input, if no input is given then quit
            Console.WriteLine("Enter numbers separated by hypen (e.g. 5-6-7-8):");
            var userInput = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(userInput))
            {
                if (FindDuplicate(userInput))
                    Console.WriteLine("Duplicates exists");
                else
                    Console.WriteLine("No duplicates");
            }

            // Ask user for time, ensure that it is within a given range
            Console.Write("Enter a valid time in 24 hour format: ");
            var timeInput = Console.ReadLine();
            if(ValidateTime(timeInput))
                Console.WriteLine("Valid time");
            else
                Console.WriteLine("Input not valid");

            // Take user sentence and turn into pascal case
            Console.Write("Enter a sentence: ");
            var sentenceInput = Console.ReadLine();
            Console.WriteLine(SentenceToPascal(sentenceInput));

            // Count the number of vowels in the user's input
            Console.Write("Enter a word: ");
            var wordInput = Console.ReadLine();
            Console.WriteLine("There are {0} vowel(s) in you word.", CountVowels(wordInput));

        }


        public static bool IsConsectuive(string numString)
        {
            var strNumbers = numString.Split('-');
            var numbers = new List<int>();

            foreach (var n in strNumbers)
            {
                numbers.Add(Convert.ToInt32(n));
            }

            if (numbers.Count == 1)
            {
                return true;
            }

            var difference = numbers[1] - numbers[0];
            if (Math.Abs(difference) != 1)
            {
                return false;
            }

            for (var i = 1; i < numbers.Count; i++)
            {
                if ((numbers[i] - numbers[i - 1]) != difference)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool FindDuplicate(string inputString)
        {
            var strNumbers = inputString.Split('-');
            var numbers = new List<int>();

            foreach (var n in strNumbers)
            {
                numbers.Add(Convert.ToInt32(n));
            }

            if (numbers.Count == 1)
            {
                return false;
            }

            foreach (var n in numbers)
            {
                if (numbers.IndexOf(n) != numbers.LastIndexOf(n))
                    return true;
            }

            return false;
        }

        public static bool ValidateTime(string input)
        {
            var timeArray = input.Split(':');
            var hour = Convert.ToInt32(timeArray[0]);
            var minute = Convert.ToInt32(timeArray[1]);

            if (hour >= 0 && hour <= 24)
            {
                if (minute >= 0 && minute <= 60)
                {
                    return true;
                }
            }
            return false;
        }

        public static string SentenceToPascal(string input)
        {
            var lowercaseString = input.ToLower();
            var strArray = lowercaseString.Split(' ');

            for(var i = 0; i < strArray.Length; i++)
            {
                strArray[i] = strArray[i].Substring(0, 1).ToUpper() + strArray[i].Substring(1);
            }
            return String.Join("", strArray); 
        }

        public static int CountVowels(string word)
        {
            var lowercaseWord = word.ToLower();
            var vowelString = "aeiou";
            int vowelCount = 0;

            foreach (var letter in lowercaseWord)
            {
              if(vowelString.IndexOf(letter) != -1)
                {
                    vowelCount++;
                }
            }
            return vowelCount; 
        }
    }
}
