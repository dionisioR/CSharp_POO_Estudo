using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Enumeracoes.Entities.Enums {
    internal enum OrderStatus:int {
        PendingPayment = 0,  // Pagamento Pendente
        Processing = 1,  // Processando
        Shipped = 2,  // Enviando
        Delivered = 3, // Entregue
        Canceled = 4  // Cancelado
    }
}
