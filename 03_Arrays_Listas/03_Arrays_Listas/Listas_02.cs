using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Arrays_Listas {
    internal class Listas_02 {
        public static void Executar() {
            List<string> list = new List<string>();

            // Adicionando elementos no final da lista
            list.Add("Maria");
            list.Add("Marcos");
            list.Add("Anna");
            list.Add("Bob");
            list.Add("Ana");
            list.Add("Ana Maria");
            list.Add("Alex");

            // Adiciona elementos em uma determinada posição
            list.Insert(2, "Joaquim");
            list.Insert(3, "Pedro");

            foreach (var item in list) {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");

            // quantidade
            Console.WriteLine("Quantidade: " + list.Count);

            // Procurando um nome que começa com a letra 'A'
            // retorna o primeiro elemento que encontrar
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine(s1);

            // retorna o último elemento que encontrar
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine(s2);

            // retorna a posição da primeira ocorrência
            int pos_1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine(pos_1);

            // retorna a posição da última ocorrência
            int pos_2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(pos_2);
            Console.WriteLine("-----------------");


            // retorna todos o elementos que atendem a um requisito (ou regra)
            // Todos os nomes que iniciam com a letra 'A'
            List<string> list2 = list.FindAll(x => x[0] == 'A');
            foreach(var item in list2) {
                Console.WriteLine(item);
            }

            // Todos os nomes que tenham três caracteres
            Console.WriteLine("-----------------");
            List<string> list3 = list.FindAll(x => x.Length == 3);
            foreach (var item in list3) {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");

            // remove o primeiro elemento que atende ao requisito
            list.Remove("Alex");
            foreach(var item in list) {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");

            // remove todo os elementos que atendam ao requisito
            list.RemoveAll(x => x[0] == 'M');
            foreach (var item in list) {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("-----------------");

            // remove o elemento na posição 3
            list.RemoveAt(3);
            foreach (var item in list) {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------");

            // RemoveRange
            // remove os elementos dentro de um intervalo (remove três itens a partir da posção 2)
            list.RemoveRange(2, 3);
            foreach (var item in list) {
                Console.WriteLine(item);
            }
        }
    }
}
