using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Funcoes_Especiais {
    internal class DateTime_03 {

        public static void Executar() {
            DateTime d = DateTime.Now;
            Console.WriteLine(d);
            Console.WriteLine("DATA: " + d.Date);
            Console.WriteLine("Dia: " + d.Day);
            Console.WriteLine("Dia da Semana: " + d.DayOfWeek);
            Console.WriteLine("Dia do ano: " + d.DayOfYear);
            Console.WriteLine("Hora: " + d.Hour);
            Console.WriteLine("Kind: " + d.Kind);
            Console.WriteLine("Milissegundo: " + d.Millisecond);
            Console.WriteLine("Minuto: " + d.Minute);
            Console.WriteLine("Mês: " + d.Month);
            Console.WriteLine("Segundo: " + d.Second);
            Console.WriteLine("Ticks: " + d.Ticks);
            Console.WriteLine("Ano: " + d.Year);
            Console.WriteLine("TimeOfDay: " + d.TimeOfDay);
        }
    }
}
