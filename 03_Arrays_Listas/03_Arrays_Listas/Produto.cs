﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Arrays_Listas {
    internal class Produto {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public override string ToString() {
            return $"Produto: {Nome}, Preço: R${Preco.ToString("F2")}";
        }
    }
}
