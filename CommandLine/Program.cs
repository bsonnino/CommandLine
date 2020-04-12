using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Linq;
using System.Threading.Tasks;

namespace CommandLine
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var command = new RootCommand
            {
                new Option(new [] {"--verbose", "-v"}),
                new Option("--numbers") { Argument = new Argument<int[]>() }
            };

            command.Handler = CommandHandler.Create(
                (bool verbose, int[] numbers) =>
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
                });
            await command.InvokeAsync(args);
        }
    }
}
