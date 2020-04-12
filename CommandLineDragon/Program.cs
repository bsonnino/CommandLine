using System;
using System.Linq;

namespace CommandLineDragon
{
    class Program
    {
        static void Main(bool verbose, int[] numbers)
        {
            if (numbers != null)
            {
                if (verbose)
                    Console.WriteLine($"Adding {string.Join(' ', numbers)}");

                Console.WriteLine(numbers.Sum());
            }
            else
            {
                if (verbose)
                    Console.WriteLine("No numbers to sum");
            }
        }
    }
}
