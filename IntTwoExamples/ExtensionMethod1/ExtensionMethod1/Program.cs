using System;

namespace ExtensionMethod1
{
    public class Program
    {
        public static void Main()
        {

            DateTime dt = new DateTime(2020, 03, 15, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

        }
    }
}
