using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Construtor_Sobrecarga_Encapsulamento_This {
    internal class Properties {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Properties() { }
        public Properties(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }
        public double Preco {
            get { return _preco; }
        }

        public int Quantidade {
            get { return _quantidade; }
        }
        public void Adicionar(int quantidade) {
            _quantidade += quantidade;
        }

        public override string ToString() {
            return $"Nome: {_nome}, Preço: {_preco} e Quantidade: {_quantidade}.";
        }
    }
}
