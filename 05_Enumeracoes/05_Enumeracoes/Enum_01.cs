using _05_Enumeracoes.Entities;
using _05_Enumeracoes.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Enumeracoes {
    internal class Enum_01 {

        // É um tipo especial que server para especificar de forma literal um conjunto de constantes relacionadas
        // Palavra Chave em C#: enum
        // -- Nota: enum é um tipo valor
        // Vantagem: melhor semântica, código mais legível e auxiliado pelo compilador
        public static void Executar() {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            // Conversões
            Console.WriteLine("\nConvertendo ENUM para STRING");
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            Console.WriteLine("\nConvertendo STRING para ENUM");
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // o texto deve ser identico ao descrito no enum
            Console.WriteLine(os);
        }
    }
}
