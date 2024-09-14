using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Funcoes_Especiais {
    internal class DateTime_02 {
        public static void Executar() {
            DateTime d1 = new DateTime(2024, 09, 14);
            Console.WriteLine(d1);
            
            DateTime d2 = new DateTime(2024, 09, 15, 4, 55, 33);
            Console.WriteLine(d2);         
            
            DateTime d3 = new DateTime(2024, 09, 15, 4, 55, 33, 550);
            Console.WriteLine(d3);

            DateTime d4 = DateTime.Now;
            Console.WriteLine(d4);

            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);

            DateTime d6 = DateTime.UtcNow; // Horário greenwich
            Console.WriteLine(d6);

            DateTime d7 = DateTime.Parse("2024-09-09");
            Console.WriteLine(d7);

            DateTime d8 = DateTime.Parse("2024-10-09 13:45:59");
            Console.WriteLine(d8);

            DateTime d9 = DateTime.Parse("15/08/2024");
            Console.WriteLine(d9);

            DateTime d10 = DateTime.Parse("28/11/2024 12:41:55");
            Console.WriteLine(d10);

            DateTime d11 = DateTime.ParseExact("2024-09-09 15:05:59", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);

        }
    }
}
