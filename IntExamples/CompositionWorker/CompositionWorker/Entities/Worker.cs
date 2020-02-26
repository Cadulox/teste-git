using System.Collections.Generic;
using CompositionWorker.Entities.Enums;

namespace CompositionWorker.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        // Composition - Associação entre duas classes diferentes
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        // Lista de vários objetos HourContract

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract); // Adiciona o argumento contract no atributo List Contracts
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract); // Remove o argumento contract do atributo List Contracts
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            // O trabalhador de qualquer maneira vai receber o salário base
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month) {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
