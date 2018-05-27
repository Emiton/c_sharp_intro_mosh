using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpanDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes); // takes minutes object
            Console.WriteLine("Total minutes: " + timeSpan.TotalMinutes); // takes all objects and converts to minutes (H:M:S)

            // Add, subtract
            Console.WriteLine("Add example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract example: " + timeSpan.Subtract(TimeSpan.FromMinutes(3)));

            // To String 
            Console.WriteLine("String: " + timeSpan.ToString()); // no need to call it in Console.WriteLine

            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
