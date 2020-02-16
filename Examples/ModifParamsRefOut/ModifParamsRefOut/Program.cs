using System;

namespace ModifParamsRefOut {
    class Program {
        static void Main(string[] args) {

            // Nota: ambos, REF e OUT, são considerados "code smells" (design ruim)
            // e devem ser evitados.
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}
