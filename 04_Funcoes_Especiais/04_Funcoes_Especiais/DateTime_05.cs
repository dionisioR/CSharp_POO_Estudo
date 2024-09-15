using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Funcoes_Especiais {
    internal class DateTime_05 {
        public static void Executar() {
            DateTime d = DateTime.Now;
            Console.WriteLine(d);

            DateTime d1 = d.AddDays(10);
            Console.WriteLine(d1);

            DateTime d2 = d.AddHours(48);
            Console.WriteLine(d2);

            DateTime d3 = d.AddHours(10);
            Console.WriteLine(d3);

            DateTime d4 = d.AddMilliseconds(2000);
            Console.WriteLine(d4);

            DateTime d5 = d.AddMinutes(60);
            Console.WriteLine(d5);

            DateTime d6 = d.AddMonths(12);
            Console.WriteLine(d6);

            DateTime d7 = d.AddSeconds(120);
            Console.WriteLine(d7);

            DateTime d8 = d.AddTicks(9000000000);   
            Console.WriteLine(d8);

            DateTime d9 = d.AddYears(4);
            Console.WriteLine(d9);

            DateTime d10 = d.AddYears(5);

            // Subtraindo datas
            TimeSpan t = d10.Subtract(d);
            Console.WriteLine(t);
        }
    }
}
