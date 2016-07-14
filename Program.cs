using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "World";

            // See if an argument was passed from the command line
            if (args.Length == 1)
                name = args[0];

            Console.WriteLine("Hello again & again, " + name + ". Today is the 14th of July!");
            Console.WriteLine("Hello " + name + ". Toda");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
