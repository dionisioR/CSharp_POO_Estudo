using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Funcoes_Especiais {
    internal class DateTime_04 {
        public static void Executar() {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);

            string s1 = d1.ToLongDateString();
            Console.WriteLine(s1);

            string s2 = d1.ToLongTimeString();
            Console.WriteLine(s2);

            string s3 = d1.ToShortDateString();
            Console.WriteLine(s3);

            string s4 = d1.ToShortTimeString();
            Console.WriteLine(s4);

            string s5 = d1.ToString();
            Console.WriteLine(s5);

            string s6 = d1.ToString("yyy-MM-dd HH:mm:ss");
            Console.WriteLine(s6);

            string s7 = d1.ToString("dd/MM/yyyy HH:mm:ss");
            Console.WriteLine(s7);

            string s8 = d1.ToString("dd/MM/yyyy HH:mm:ss.fff");
            Console.WriteLine(s8);


        }
    }
}
