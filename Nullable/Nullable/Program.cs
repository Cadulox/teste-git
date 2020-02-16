using System;

namespace Nullable {
    class Program {
        static void Main(string[] args) {

            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value); // Vai me dar um exceção se eu tentar chamar objeto com valo null
            else
                Console.WriteLine("X is null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            Console.WriteLine();
            /*
             * Operador de coalescência nula (??)
             * Demo:
             * double? x = null;
             * double y = x ?? 0.0;
             */

            double? e = null;
            double? f = 10;

            double a = e ?? 5;
            double b = f ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
