using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _03_Arrays_Listas {
    internal class Nullable {

        // valores que podem recener null
        Nullable<double> x = null;

        // double? y = null;
        double? y = 10;

        public void Imprimir() {
            // GetValueOrDefault - Pega o valor que tem ou o valor default
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            // HasValue - retorna true ou false caso a variável tem valor
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            // Value (lança uma exceção se não houver valor)
            // Console.WriteLine(x.Value); - lança um erro pois não tem valor
            Console.WriteLine(y.Value);

            Console.WriteLine(x.HasValue ? x.Value : "Não tem valor...");
            Console.WriteLine(y.HasValue ? y.Value : "Não tem valor...");

            // Um nullable não pode ser atribuído para um struct comum
        }

    }
}
