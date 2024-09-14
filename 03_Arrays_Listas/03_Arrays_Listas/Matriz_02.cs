using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Arrays_Listas {
    internal class Matriz_02 {

        public static void Executar() {
            Console.Write("Informe o tamanho da matriz de ordem N:  ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            // Preenchendo a matriz
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Random random = new Random();
                    matriz[i, j] = random.Next(-100, 100) + 1;
                }
            }
            Console.WriteLine();
            // Imprimindo a matriz
            Console.WriteLine("\nMatriz gerada:");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Diagonal principal");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (i == j) {
                        Console.Write($"{matriz[i, j]} ");
                    }
                    else {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            int qtdNumerosNegativos = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (matriz[i, j] < 0) { 
                        qtdNumerosNegativos++;
                    }
                }
            }
            Console.WriteLine("A Matriz possue " + qtdNumerosNegativos + " números negativos");
        }
    }
}