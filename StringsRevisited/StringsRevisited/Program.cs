using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsRevisited
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Emiton Alves ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());


            // Split full name
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First name: " + names[0]);
            Console.WriteLine("Last name: " + names[1]);
            
            Console.WriteLine(fullName.Replace("Emiton", "King"));

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");


            var str = "24";
            var age = Convert.ToByte(str);

            float price = 29.95f;
            price.ToString("C0"); // will round when formatting to no decimal places

        }
    }
}
