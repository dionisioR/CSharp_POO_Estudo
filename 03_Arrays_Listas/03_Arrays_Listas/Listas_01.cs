using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Listas
----------------------
- Lista é uma estrutura de dados:
-- Homogênea (dados do mesmo tipo)
-- Ordenada (elements acessados por meio de posições)
-- inicia vazia, e seus elementos são alocados sob demanda
-- cada elemento ocupa um nó (ou nodo) da lista

- Classe: List
- Namespace: System.Collection.Generic

- Vantagem:
-- Tamanho variável
-- Facilidade para se realizar inserçõs e deleçõs

- Desvantagem:
-- Acesso sequencial aos elementos
 */
namespace _03_Arrays_Listas {
    internal class Listas_01 {
        public static void Executar() { 
            // Lista vazia
            List <string> list = new List <string> ();

            // Lista com elementos
            List<string> list2 = new List<string> { "Maria", "Bob", "Ana" };

            foreach (var item in list2)
            {
                Console.WriteLine (item);
            }
        }
    }
}
