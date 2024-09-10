using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Construtor_Sobrecarga_Encapsulamento_This {
    internal class produtoThis {
        private string nome;
        private int quantidade;
        private double valor;
        private string descricao;

        public produtoThis() {
            this.quantidade = 0;
        }

        public produtoThis(string nome) : this() {
            this.nome = nome;

        }
        public produtoThis(string nome, string descricao, int valor) : this(nome) {
            this.valor = valor;
            this.descricao = descricao;
        }

        public string getNome() {
            return nome;
        }
        public int getQuantidade() {
            return quantidade;
        }
        public double getValor() {
            return valor;
        }
        public string getDescricao() {
            return descricao;
        }
        public void setNome(string nome) {
            if(nome != null && nome.Length > 1) {
                this.nome = nome;
            }
            else {
                Console.WriteLine("Nome inválido. Deve ter mais de 1 caractere.");
            }
        }
        public void setQuantidade(int quantidade) {
            this.quantidade = quantidade;
        }
        public void setValor(double valor) {
            this.valor = valor;
        }
        public void setDescricao(string descricao) {
            this.descricao = descricao;
        }
        public override string ToString() {
            return $"Nome: {nome}, Descrição: {descricao}, Valor: {valor}, Quantidade: {quantidade}";
        }
}
    }