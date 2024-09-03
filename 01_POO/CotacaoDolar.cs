using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_POO {
    public class CotacaoDolar {
        public static double cotacaoDolar;
        public static double quantidadeComprar;
        private static double iof = 6;

        public static double DolarParaReal() {
            return quantidadeComprar * cotacaoDolar * (1 + iof / 100);
        }
        public static string ValorPagar() {
            return $"Valor a ser pago em reais: R${DolarParaReal().ToString("f2")}";
        }
    }
}
