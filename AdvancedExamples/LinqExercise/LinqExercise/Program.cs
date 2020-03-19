using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using LinqExercise.Entities;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> employees = new List<Employee>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        employees.Add(new Employee(name, email, salary));
                    }
                }

                Console.WriteLine($"Email of people whose salary is more than {amount.ToString("F2", CultureInfo.InvariantCulture)}:");
                var emails = employees.Where(p => p.Salary > amount).OrderBy(p => p.Email).Select(p => p.Email);
                foreach (string email in emails)
                {
                    Console.WriteLine(email);
                }

                var sum = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
