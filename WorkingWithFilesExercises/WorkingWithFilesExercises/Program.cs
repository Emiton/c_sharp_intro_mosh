using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkingWithFilesExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\MEAN\TestFile.txt";
            var wholeFile = File.ReadAllText(path);

            // Write a program that opens a file and displays the number of words
            Console.WriteLine(WordCounter(wholeFile));


            // Write a program that reads a text file and displays the longest word
            Console.WriteLine(FindLongestWord(wholeFile));
        }



        public static int WordCounter(string file)
        {
            var wordCount = 0;
            var wordArray = file.Split(' ');
            var punctuation = ",./\'\"\\:;`~+=-_!@#$%^&*(){}[]?";

            foreach (var word in wordArray)
            {
                if (punctuation.IndexOf(word) == -1)
                {
                    wordCount++;
                }
            }

            return wordCount;
        }

        public static string FindLongestWord(string file)
        {
            int maxLength = 0;
            String longestWord = "";
            var wordArray = file.Split(' ');

            foreach (var word in wordArray)
            {
                if (word.Length > maxLength)
                    longestWord = word;
            }

            return longestWord;
        }

    }
}
