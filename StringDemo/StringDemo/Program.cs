﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Emiton";
            var lastName = "Alves";
            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] {"Blue", "Hat", "Joe"};
            var formattedName = string.Join(",", names);
            Console.WriteLine(formattedName);
        }
    }
}
