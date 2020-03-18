using System;
using System.Collections.Generic;
using FuncExample.Entities;
using System.Linq;

namespace FuncExample
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //4ª maneira e mais reduzida
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            //3ª maneira
            //Func<Product, string> func = p => p.Name.ToUpper();
            //List<string> result = list.Select(func).ToList();

            //2ª maneira
            //Func<Product, string> func = NameUpper;
            //List<string> result = list.Select(func).ToList();

            //1ª maneira
            //List<string> result = list.Select(NameUpper).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
