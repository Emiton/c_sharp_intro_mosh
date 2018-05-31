using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PathDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\FakeDirectory\FakeFile.sln";
            var dotIndex = path2.IndexOf('.');
            var extension = path2.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("Filename: " + Path.GetFileName(path));
            Console.WriteLine("Filename without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory: " + Path.GetDirectoryName(path));
        }
    }
}
