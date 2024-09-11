using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Arrays_Listas {
    internal class Aluguel {
        public int NumeroQuarto { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Aluguel(int numero, string nome, string email)
        {
            NumeroQuarto = numero;
            Nome = nome;
            Email = email;
        }
        public override string ToString() {
            return $"Nome: {Nome}, E-mail: {Email} e Número do quarto: {NumeroQuarto}";
        }
    }
}
