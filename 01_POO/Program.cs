
using System;

namespace _01_POO {
    public class Program {
        static void Main() {
            /*
            Produto p = new Produto();
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            p.quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------");
            Console.WriteLine("Dados do produto:");
            Console.WriteLine("---------------------------");
            Console.WriteLine(p);
            Console.WriteLine($"Valor total em estoque: R${p.ValotTotalEmEstoque().ToString("F2")}");
            Console.WriteLine("---------------------------\n");

            Console.WriteLine("Digite a quantidade de produtos a ser adicionada: ");
            p.AdicionarProduto(int.Parse(Console.ReadLine()));
            Console.WriteLine("---------------------------\n");
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(p);

            Console.WriteLine("---------------------------\n");

            Console.WriteLine("Digite a quantidade de produtos a ser removida: ");
            p.RemoverProduto(int.Parse(Console.ReadLine()));
            Console.WriteLine("---------------------------\n");
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(p);
            */
            /*
            Console.WriteLine("EXERCÍCIO 01: ");
            Retangulo r = new Retangulo();
            Console.WriteLine("Digite o valor referente aos lados do retângulo: ");
            Console.Write("Altura:");
            r.altura = double.Parse(Console.ReadLine());      
            Console.Write("Largura:");
            r.largura = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------");
            Console.WriteLine(r);
            Console.WriteLine("---------------------------");
            */
            /*
            Console.WriteLine("EXERCÍCIO 02: ");
            Funcionario f = new Funcionario();
            Console.Write("Digite o nome do funcionário: ");
            f.nome = Console.ReadLine();
            Console.Write("Digite o valor do salário bruto: ");
            f.salario_bruto = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------");
            Console.WriteLine(f);
            Console.WriteLine("---------------------------");
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            f.AumentarSalario(double.Parse(Console.ReadLine()));
            Console.WriteLine("---------------------------");
            Console.WriteLine(f);
            */

            /*
            Console.WriteLine("EXERCÍCIO 03: ");
            Aluno aluno = new Aluno();
            Console.Write("Digite o nome do aluno: ");
            aluno.nome = Console.ReadLine();
            Console.Write("Digite a primeira nota: ");
            aluno.nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            aluno.nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            aluno.nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------");
            Console.WriteLine(aluno);
            */

            Console.WriteLine("EXERCÍCIO 04: ");
            Console.Write("Qual a contação do Dolar? ");
            CotacaoDolar.cotacaoDolar = double.Parse(Console.ReadLine());
            Console.Write("Quantos dolares você quer comprar? ");
            CotacaoDolar.quantidadeComprar = double.Parse(Console.ReadLine());
            Console.WriteLine(CotacaoDolar.ValorPagar());


        }
    }
}