using System.CommandLine.Invocation;
using System.CommandLine.Rendering;
using System.CommandLine.Rendering.Views;
using System.IO;
using System.Linq;

namespace FileInfoRender
{
    class Program
    {
        static void Main(InvocationContext context, DirectoryInfo argument= null)
        {
            argument ??= new DirectoryInfo(".");
            var consoleRenderer = new ConsoleRenderer(
                context.Console,
                context.BindingContext.OutputMode(),
                true);

            var tableView = new TableView<FileInfo>
            {
                Items = argument.EnumerateFiles().ToList()
            };

            tableView.AddColumn(f => f.Name, "Name");

            tableView.AddColumn(f => f.LastWriteTime, "Modified");

            tableView.AddColumn(f => f.Length, "Size");

            var screen = new ScreenView(consoleRenderer, context.Console) { Child = tableView };
            screen.Render();
        }
    }
}
