using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Funcoes_Especiais {
    internal class DateTime_01 {

        // Um objeto DateTime internamente armazena:
        // --- O número de 'ticks' (100 nanosegundos) desde a meia noite do dia 1 de janeiro do ano 1 da era comum
        public static void Executar() {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            //  DateTime dt1 = new DateTime(2022, 1, 1);
            //  DateTime dt2 = DateTime.Today;
        }
    }
}