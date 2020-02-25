using System;
using System.Globalization;

namespace DateAndTime {
    class Program {
        static void Main(string[] args) {

            /*
            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            Console.WriteLine(date.Ticks);
            Console.WriteLine();

            DateTime d1 = new DateTime(2020, 02, 24);
            DateTime d2 = new DateTime(2020, 02, 24, 21, 22, 3);
            DateTime d3 = new DateTime(2020, 02, 24, 21, 22, 3, 500);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            */

            /*
            DateTime d1 = DateTime.Parse("2000-08-15");
            // .Parse aceita vários formatos
            DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");

            DateTime d3 = DateTime.Parse("24/02/2020");
            DateTime d4 = DateTime.Parse("24/02/2020 13:05:58");

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            */

            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
        }
    }
}
