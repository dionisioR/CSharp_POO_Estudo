using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Arrays_Listas {
    internal class Matriz_01 {
        /*
         * Em programação 'matriz' ó nome dado a arranjos bidimensionais.
         * 
         * Arranjo é um estrutura de dados:
         *  -- Homogênea (dados do mesmo tipo)
         *  -- Ordenada (elementos acessados por meio de posições)
         *  -- Alocada de uma vez só, em um bloco contíguo de me^mória.
         *  
         *  Vantagens:
         *  -- Acesso imediato aos elementos pela sua posição
         *  
         *  Desvantagens:
         *  -- Tamanho fixo
         *  -- dificuldade para se realizar inserções e deleções
         *  
         *  
         * Matrizes em C# são arrays bidimensionais, que podem ser declaradas da seguinte forma:
         * 
         * int[,] matriz = new int[linhas, colunas];
         * 
         * Por exemplo:
         * 
         * int[,] matriz = new int[3, 4]; // Matriz de 3 linhas e 4 colunas
         * 
         * Podemos inicializar valores na matriz durante a declaração:
         * 
         * int[,] matriz = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
         * 
         * Podemos usar a notação de índice para acessar os elementos da matriz:
         * 
         * Console.WriteLine(matriz[1, 2]);}
         */

        public static void Executar() {
            double[,] matrix = new double[2,5];

            Console.WriteLine(matrix.Length);  // 10 celulas
            Console.WriteLine(matrix.Rank);  // 2 linhas
            Console.WriteLine(matrix.GetLength(0)); // 2 - quantidade de elementos da primeira posição (quantidade de linhas)
            Console.WriteLine(matrix.GetLength(1)); // 5 - quantidade de elementos da segunda posição (quantidade de colunas)
        }


    }
}
