using System;
using System.Collections.Generic;

namespace List {
    class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>(); // Cria uma lista vazia

            List<string> list2 = new List<string> { "Maria", "Alex" }; // Cria uma lista com elementos

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Amna");

            list.Insert(2, "Marco");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A'); // Expressão lambda
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> list3 = list.FindAll(x => x.Length == 5);
            // Acha qualquer elemento de tamanho 5 e adiciona na nova lista
            Console.WriteLine("--------------------------");
            foreach (string obj in list3) {
                Console.WriteLine(obj);
            }

            list.RemoveAt(3);
            // Remove um elemento pelo seu index
            Console.WriteLine("--------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            // Remove um elemento cujo o nome seja idêntico ao parâmetro passado
            Console.WriteLine("--------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            // Vai remover todos elementos que começam com a letra M
            Console.WriteLine("--------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Marco");
            Console.WriteLine("--------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2); 
            // Remove a partir da posição 2, dois elementos
            Console.WriteLine("--------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
