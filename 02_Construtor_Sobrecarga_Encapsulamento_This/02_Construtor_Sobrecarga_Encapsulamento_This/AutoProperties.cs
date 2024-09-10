using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Construtor_Sobrecarga_Encapsulamento_This {
    internal class AutoProperties {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public AutoProperties() { }
        public AutoProperties(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }
      
        public void Adicionar(int quantidade) {
            Quantidade += quantidade;
        }

        public override string ToString() {
            return $"Nome: {_nome}, Preço: {Preco} e Quantidade: {Quantidade}.";

        }
    }
}