using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Classes.Math;
using System;

namespace Classes
{ 

    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            var calculator = new Calculator();
            var result = calculator.Add(1,2);
            Console.WriteLine(result);
        }
    }
}
