using System;

namespace Matriz {
    class Program {
        static void Main(string[] args) {

            double[,] mat = new double[2, 3];
            // Instancia uma matriz de 2 linhas e 3 colunas

            Console.WriteLine(mat.Length);

            Console.WriteLine(mat.Rank);
            // Mostra a quantidade de linhas

            Console.WriteLine(mat.GetLength(0));

            Console.WriteLine(mat.GetLength(1));
        }
    }
}
