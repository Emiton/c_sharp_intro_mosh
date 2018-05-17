using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Perform explicit an explicit cast
            int i = 1000;
            byte b = (byte) i;
            Console.WriteLine(b);
            */

            // Look at incompatible types

            /*
             * Create an exception when attempting to cast
            string number = "1234";
            int i = (int)number;
            byte b = Convert.ToByte(number);
            Console.WriteLine(b);
            */

            // Try your hand at handling exceptions

            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);

            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");

            }

            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);

            }
            catch (Exception)
            {
                Console.WriteLine("The string could not be converted to bool.");

            }


        }
    }
}
