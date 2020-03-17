using System;
using System.IO;
using System.Collections.Generic;

namespace FileExample5
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\temp\myfolder";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                //var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
