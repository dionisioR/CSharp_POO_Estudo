using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Arrays_Listas {
    internal class Funcionario {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario) { 
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public void IncrementarSalario(double percentagem) {
            if (percentagem > 0) {
                Salario += Salario * (percentagem / 100);
            }
        }

        public override string ToString() {
            return $"ID: {Id}, Nome: {Nome}, Salário: R${Salario.ToString("F2")}";
        }
    }
}
