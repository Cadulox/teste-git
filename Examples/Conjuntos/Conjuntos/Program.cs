using System;
using System.Collections.Generic;

namespace Conjuntos {
    class Program {
        static void Main(string[] args) {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            //B.Remove(5);
            // Remove um elemento do conjunto

            //B.Add(4);
            // Um conjunto não repete elemento

            //A.ExceptWith(B);
            // Remove de A o que é repetido em B

            //A.UnionWith(B);
            // Vai alterar A e unir com os elementos de B

            A.IntersectWith(B);
            // Vai fazer a intersecção de A e B

            foreach (int x in A) {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            Console.Write("Digite um valor inteiro: ");
            int N = int.Parse(Console.ReadLine());

            if (B.Contains(N)) {
                Console.WriteLine(N + " pertence ao conjunto B");
            }
            else {
                Console.WriteLine(N + " não pertence ao conjunto B");
            }
        }
    }
}
