using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Funcoes_Especiais {
    internal class TimeSpan_02 {

        public static void Executar() {
            TimeSpan t1 = TimeSpan.FromDays(1.5); // um dia e meio
            Console.WriteLine(t1);  // 1.12:00:00

            TimeSpan t2 = TimeSpan.FromHours(1.5); // uma hora e meia
            Console.WriteLine(t2);  // 1:30:00

            TimeSpan t3 = TimeSpan.FromMinutes(90); // 90 minutos
            Console.WriteLine(t3);  // 1:30:00


            TimeSpan t5 = TimeSpan.FromMinutes(1.5); // um minuto e meio
            Console.WriteLine(t5);  // 00:01:30

            TimeSpan t4 = TimeSpan.FromSeconds(90); // 90 segundos
            Console.WriteLine(t4); // 00:01:30

            TimeSpan t6 = TimeSpan.FromSeconds(1.5); // um segundo e meio
            Console.WriteLine(t6); // 00:00:01.5000000

            TimeSpan t7 = TimeSpan.FromMilliseconds(1500); // 1500 milissegundos
            Console.WriteLine(t7); // 00:00:01.5000000

            TimeSpan t8 = TimeSpan.FromTicks(1500000000L); 
            Console.WriteLine(t8); // 00:02:30 
        }
    }

}