using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.IONamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);

            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }
            */

            /*
            // Directory and DirectoryInfo
            Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"C:\Users\Andrzej\source\repos\System.IONamespace\System.IONamespace", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine("\nNow GetDirectories: \n");

            var directories = Directory.GetDirectories(@"C:\Users\Andrzej\source\repos\System.IONamespace\System.IONamespace", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

            Console.ReadLine();
            */

            // Path

            var path = @"C:\Users\Andrzej\source\repos\System.IONamespace\System.IONamespace";

            Console.WriteLine($"Extension: {Path.GetExtension(path)}");
            Console.WriteLine($"File Name: {Path.GetFileName(path)}");
            Console.WriteLine($"File Name: {Path.GetFileNameWithoutExtension(path)}");
            Console.WriteLine($"Directory Name: {Path.GetDirectoryName(path)}");

            Console.ReadLine();
        }
    }
}
