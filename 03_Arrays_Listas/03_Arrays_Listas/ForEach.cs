using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Arrays_Listas {
    internal class ForEach {

        public static void Executar() {
            string[] str = new string[] { "Maria", "Bob", "Ana", "Alex" };
            foreach (string item in str) {
                Console.WriteLine(item);
            }
        }
    }
}