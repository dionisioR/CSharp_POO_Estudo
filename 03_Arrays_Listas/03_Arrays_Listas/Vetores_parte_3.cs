using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Arrays_Listas {
    internal class Vetores_parte_3 {
        public static void Executar() {

            Console.Write("Digite a quantidade de cadastros: ");
            int cadastros = int.Parse(Console.ReadLine());

            int qtd = 10;
            Aluguel[] quartos = new Aluguel[qtd];

            for (int i = 0; i < cadastros; i++) {
                Console.Write($"Digite o nome do cliente {i + 1}: ");
                string nome = Console.ReadLine();
                Console.Write($"Digite o email do cliente {i + 1}: ");
                string email = Console.ReadLine();
                Console.Write($"Digite número do quarto {i + 1}: ");
                int numeroQuarto = int.Parse(Console.ReadLine());

                quartos[numeroQuarto-1] = new Aluguel(numeroQuarto,nome,email);
            }

            for (int i = 0; i < qtd; i++) {

                if (quartos[i] != null) {
                    Console.WriteLine(quartos[i].ToString());
                }
            }
        }
    }
}