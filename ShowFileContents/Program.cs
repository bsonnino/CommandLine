using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Threading.Tasks;

namespace ShowFileContents
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var command = new RootCommand
            {
                new Argument<StreamReader>("stream")
            };

            command.Handler = CommandHandler.Create(
                (StreamReader stream) =>
                {
                    var fileContent = stream.ReadToEnd();
                    Console.WriteLine(fileContent);
                });
            await command.InvokeAsync(args);
        }

    }
}