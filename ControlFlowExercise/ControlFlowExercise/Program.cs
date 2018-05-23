using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Validate a number input from user
            Console.WriteLine("====INPUT VALIDATION PROGRAM====");
            var isValid = false;
            var input = -1;

            do
            {
                Console.Write("Enter a number: ");
                input = Int32.Parse(Console.ReadLine());

                if (input >= 1 && input <= 10 )
                {
                    Console.WriteLine("Valid");
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            } while (!isValid);

            // Ask for two numbers and display the larger of the two
            Console.WriteLine("====MAX INPUT PROGRAM====");
            int a, b;
            Console.Write("Enter your first number: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            b = Int32.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a);
            }
            else if (b > a)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("Gasp! You have broken my infallible logic.");
            }

            // Get height and width of an image, report if image is landscape or portrait
            // I stole my logic from my solution above, it's the same thing
            Console.WriteLine("====IMAGE FORMAT PROGRAM====");
            int height, width;
            Console.Write("Enter the height of the image: ");
            height = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the width of your image: ");
            width = Int32.Parse(Console.ReadLine());

            if (height > width)
            {
                Console.WriteLine("Portrait format");
            }
            else if (width > height)
            {
                Console.WriteLine("Landscape format");
            }
            else
            {
                Console.WriteLine("How are we here again?");
            }

            // Determine penalty for violating the speed limit
            Console.WriteLine("====SPEED LIMIT PROGRAM====");
            var speedLimit = 25;
            Console.Write("Enter driver's speed: ");
            var driverSpeed = Int32.Parse(Console.ReadLine());
            var pointsOver = (driverSpeed - speedLimit) / 5;
            if (driverSpeed <= speedLimit)
            {
                Console.WriteLine("Good job.");
            }
            else if (pointsOver <= 12)
            {
                Console.WriteLine("Thank you for your contribution to the General Fund");
                Console.WriteLine("Uhh...I mean don't you speed again!");
            }
            else
            {
                Console.WriteLine("You maniac! License suspended!");
            }

            Console.WriteLine("Point penalty: {0}", pointsOver);

        }
    }
}
