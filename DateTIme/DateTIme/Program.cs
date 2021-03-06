﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTIme
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);
            Console.WriteLine();
            Console.WriteLine();

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            // Convert to string
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());

            // Use one of the format specifiers
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

        }
    }
}
