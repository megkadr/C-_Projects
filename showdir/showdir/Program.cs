using System;
using System.IO;

namespace showdir
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int folders = 0, licznik = 0;
            var pliki = Directory.GetFileSystemEntries(Directory.GetCurrentDirectory(), "*",
                SearchOption.AllDirectories);
            foreach (var plik in pliki)
            {
                var info = new FileInfo(plik);
                var atri = File.GetAttributes(info.FullName);
                if (!atri.HasFlag(FileAttributes.Directory))
                {
                    Console.Write(
                        info.CreationTime
                        + "\t   \t"
                        + $"{info.Length}\t"
                        + info.Name
                        + Environment.NewLine
                    );
                    folders++;
                }
                else
                {
                    var info2 = new DirectoryInfo(plik);
                    Console.Write(
                        info2.CreationTime
                        + "\t <DIR>"
                        + info2.Name
                        + Environment.NewLine
                    );
                    licznik++;
                }
            }

            Console.ReadKey();
        }
    }
}