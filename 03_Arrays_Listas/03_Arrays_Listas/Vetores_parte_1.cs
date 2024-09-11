using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _03_Arrays_Listas {
    internal class Vetores_parte_1 {

        public static void Executar() {
            Console.Write("Digite o tamanho do array... ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++) {
                Console.Write($"Digite o valor do elemento {i + 1}: ");
                vect[i] = double.Parse(Console.ReadLine());
            }

            // calculando a média
            double soma = 0;

            for (int i = 0; i < n; i++) {
                soma += vect[i];
            }
            double media = soma / n;
            Console.WriteLine($"Média dos elementos do vetor: {media.ToString("F2")}");

        }
    }
}