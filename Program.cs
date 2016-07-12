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

            Console.WriteLine("Hello again, " + name + "!");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
