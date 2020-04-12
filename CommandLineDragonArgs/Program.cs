using System;
using System.Linq;

namespace CommandLineDragonArgs
{
    class Program
    {
        static void Main(bool verbose, int[] args)
        {
            if (args != null)
            {
                if (verbose)
                    Console.WriteLine($"Adding {string.Join(' ', args)}");

                Console.WriteLine(args.Sum());
            }
            else
            {
                if (verbose)
                    Console.WriteLine("No numbers to sum");
            }
        }
    }
}
