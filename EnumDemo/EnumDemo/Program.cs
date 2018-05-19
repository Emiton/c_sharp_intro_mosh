using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{

    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Get the value of an enum
            var method = ShippingMethod.Express;
            Console.WriteLine((int) method);

            // Cast an int to an enum
            var methodId = 3;
            Console.WriteLine((ShippingMethod) methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";

            // Convert a string to an enum
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}
