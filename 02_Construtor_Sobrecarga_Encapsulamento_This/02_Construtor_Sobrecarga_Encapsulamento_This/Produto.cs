using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Construtor_Sobrecarga_Encapsulamento_This {
    internal class Produto {
        public string nome;
        public double preco;
        public int quantidade;

        public Produto(string nome, double preco, int quantidade) {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }


        public double ValotTotalEmEstoque() {
            return preco * quantidade;
        }

        public void AdicionarProduto(int quantidade) {
            this.quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade) {
            this.quantidade -= quantidade;
        }

        public override string ToString() {
            return $"Nome: {nome} - Preço: R$ {preco.ToString("F2")} - Quantidade: {quantidade} - Valor em estoque: {ValotTotalEmEstoque()}.";
        }
    }
}
