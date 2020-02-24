using System;
using System.Collections.Generic;

namespace ConjuntoExercise {
    class Program {
        static void Main(string[] args) {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A:");

            for (int i = 0; i < n; i++) {
                int value = int.Parse(Console.ReadLine());
                A.Add(value);
            }

            Console.Write("O curso B possui quantos alunos? ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B:");

            for (int i = 0; i < n; i++) {
                int value = int.Parse(Console.ReadLine());
                A.Add(value);
            }

            Console.Write("O curso C possui quantos alunos? ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C:");

            for (int i = 0; i < n; i++) {
                int value = int.Parse(Console.ReadLine());
                A.Add(value);
            }

            HashSet<int> Total = new HashSet<int>();
            Total.UnionWith(A);
            Total.UnionWith(B);
            Total.UnionWith(C);
            
            Console.WriteLine();
            Console.WriteLine("Total de alunos: " + Total.Count);
        }
    }
}
