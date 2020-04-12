using System;
using System.IO;

namespace FileInfoDragon
{
    class Program
    {
        /// <summary>
        /// Lists files of the selected directory.
        /// </summary>
        /// <param name="argument">The directory name</param>
        static void Main(DirectoryInfo argument)
        {
            argument ??= new DirectoryInfo(".");
            foreach (var file in argument.GetFiles())
            {
                Console.WriteLine($"{file.Name,-40} {file.Length}");
            }
        }
    }
}
