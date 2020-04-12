using System;
using System.Linq;

namespace GetPrimes
{
    class Program
    {
        static void Main(int number = 10, bool verbose = false)
        {
            var primes = GetPrimesLessThan(number);
            Console.WriteLine($"Found {primes.Length} primes less than {number}");
            Console.WriteLine($"Last prime last than {number} is {primes.Last()}");
            if (verbose)
            {
                Console.WriteLine($"Primes: {string.Join(' ',primes)}");
            }
        }

        private static int[] GetPrimesLessThan(int maxValue)
        {
            if (maxValue <= 1)
                return new int[0];
            ;
            var primeArray = Enumerable.Range(0, maxValue).ToArray();
            var sizeOfArray = primeArray.Length;

            primeArray[0] = primeArray[1] = 0;

            for (int i = 2; i < Math.Sqrt(sizeOfArray - 1) + 1; i++)
            {
                if (primeArray[i] <= 0) continue;
                for (var j = 2 * i; j < sizeOfArray; j += i)
                    primeArray[j] = 0;
            }

            return primeArray.Where(n => n > 0).ToArray();
        }
    }
}
