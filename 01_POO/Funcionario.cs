using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_POO {
    internal class Funcionario {
        public string nome;
        public double salario_bruto;
        public double imposto = 1000;

        public double SalarioLiquido() {
            return salario_bruto - imposto;
        }
        public void AumentarSalario(double porcentagem) {
            this.salario_bruto = salario_bruto * (1 + porcentagem / 100);
        }
        public override string ToString() {
            return $"Nome: {nome} - Salário Líquido: R${SalarioLiquido()}";
        }
    }
}
