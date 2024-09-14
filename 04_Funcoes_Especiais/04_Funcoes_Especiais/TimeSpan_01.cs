using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _04_Funcoes_Especiais {
    internal class TimeSpan_01 {
        // Representa uma duração
        // É um tipo valor (Struct)
        // Agenda:
        // --- Representação interna
        // --- Instanciação: Construtores, fields, métodos From, Parse
        // --- Um objeto TimeSpan internamente armazena uma duração na forma de ticks (100 nanosegundos)

        public static void Executar() {
            TimeSpan t1 = new TimeSpan();
            Console.WriteLine(t1);  // 00:00:00

            TimeSpan t2 = new TimeSpan(9000000000L);
            Console.WriteLine(t2);  //  00:15:00

            TimeSpan t3 = new TimeSpan(0, 1, 30);  // hora, minuto, segundo
            Console.WriteLine(t2);
            Console.WriteLine(t3.Ticks);

            TimeSpan t4 = new TimeSpan(23, 59, 59);
            Console.WriteLine(t4);
            Console.WriteLine(t4.Ticks);

            TimeSpan t5 = new TimeSpan(1, 2, 55, 55); // dia, hora, minuto, segundo
            Console.WriteLine(t5); // 1.02:55:55

            TimeSpan t6 = new TimeSpan(2, 3, 59, 59, 500); // dia, hora, minuto, segundo, milissegundo
            Console.WriteLine(t6);  //  2.03:59:59.5000000





        }

    }
}
