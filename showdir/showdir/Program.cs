using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showdir
{
    class Program
    {
        static void Main(string[] args)
        {
            int folders = 0, licznik = 0;
            var pliki = Directory.GetFileSystemEntries(Directory.GetCurrentDirectory(), "*", SearchOption.AllDirectories);
            foreach(var plik in pliki)
            {
                FileInfo info = new FileInfo(plik);
                FileAttributes atri = File.GetAttributes(info.FullName);
                if (!atri.HasFlag(FileAttributes.Directory))
                {
                    Console.Write(
                        info.CreationTime
                        +"\t   \t"
                        + $"{info.Length}\t"
                        + info.Name
                        + Environment.NewLine
                        );
                    folders++;
                }
                else
                {
                    DirectoryInfo info2 = new DirectoryInfo(plik);
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
