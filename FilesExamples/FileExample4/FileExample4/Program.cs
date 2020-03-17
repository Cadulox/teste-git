using System;
using System.IO;

namespace FileExample4
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourcepath = @"c:\temp\teste.txt";
            string targetpath = @"c:\temp\teste2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcepath);

                using (StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
