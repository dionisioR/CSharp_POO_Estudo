using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Arrays_Listas {
    internal class Vetores_parte_2 {

        public static void Imprimir() {
            Console.WriteLine("Digite o tamanho do array...");
            int qtd = int.Parse(Console.ReadLine());

            Produto[] vectProduto = new Produto[qtd];

            // inserindo os dados
            for (int i = 0; i < qtd; i++) {
                Console.Write($"Digite o nome do produto {i + 1}: ");
                string nome = Console.ReadLine();
                Console.Write($"Digite o preço do produto {i + 1}: ");
                double preco = double.Parse(Console.ReadLine());

                vectProduto[i] = new Produto {
                    Nome = nome,
                    Preco = preco
                };

            }

            double soma = 0;
            for (int i = 0; i < qtd; i++) {
                Console.WriteLine(vectProduto[i].ToString());
                soma += vectProduto[i].Preco;
            }

            double avg = soma / qtd;
            Console.WriteLine("Média de preço dos produtos: R$" + avg.ToString("F2"));
        }
    }
}