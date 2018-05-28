using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodeSummarizeText
{
    class Program
    {

        // Summarize a text using a string reducing method
        static void Main(string[] args)
        {
            var text = "This is going to be a really really really really really long text.";
            var summary = StringUtility.SummarizeText(text);
            Console.WriteLine(summary);
            
        }


        
    }
}
