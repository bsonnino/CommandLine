using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Threading.Tasks;

namespace FileInfoParams
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var command = new RootCommand
            {
                new Argument<DirectoryInfo>("Directory", 
                    () => new DirectoryInfo("."))
                    .ExistingOnly()
            };

            command.Handler = CommandHandler.Create(
                (DirectoryInfo directory) =>
                {
                    foreach (var file in directory.GetFiles())
                    {
                       Console.WriteLine($"{file.Name,-40} {file.Length}");
                    }
                });
            await command.InvokeAsync(args);
        }
    }
}
