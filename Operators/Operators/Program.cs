using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Play with operators
            //var a = 10;
            //var b = 3;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a / b);
            //Console.WriteLine((float)a / (float)b);

            var a = 1;
            var b = 2;
            var c = 3;


            // Operator Precedence 
            Console.WriteLine(a + b * c);

            // Comparison Operators
            Console.WriteLine(a == b);

            // Logical Operators
            Console.WriteLine(c > b && c > a);
            Console.WriteLine(c > b && c == a);
            Console.WriteLine(c > b || c == a);
            Console.WriteLine(!(c > b) || c == a);



        }
    }
}
