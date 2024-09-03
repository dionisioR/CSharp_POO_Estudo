using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_POO {
    internal class Aluno {
        public string nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public double NotaFinal() {
            return (nota1 + nota2 + nota3);
        }
        public string Resultado() {
            if(NotaFinal() >= 60) {
                return $"Nota final: {NotaFinal()} \nAprovado";
            }
            return $"Nota final: {NotaFinal()} \nReprovado \nFaltaram {60 - NotaFinal()} pontos.";
        }
        public override string ToString() {
            return $"Nome: {nome} \n{Resultado()}";
        }
    }
}
