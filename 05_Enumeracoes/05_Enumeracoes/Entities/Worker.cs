using _05_Enumeracoes.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Enumeracoes.Entities {
    internal class Worker {
        public string Name { get; set; }
        public WorkelLevel Level { get; set; }
        public double BaseSalay { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker() { }

        public Worker(string name, WorkelLevel level, double baseSalay, Department department) {
            Name = name;
            Level = level;
            BaseSalay = baseSalay;
            Department = department;
        }

        public void AddContract(HourContract contract) {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract) {
            Contracts.Remove(contract);
        }

        public double InCome(int year, int month) {
            double sum = BaseSalay;
            foreach (HourContract contract in Contracts) {
                if (contract.Date.Year == year && contract.Date.Month == month) {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}