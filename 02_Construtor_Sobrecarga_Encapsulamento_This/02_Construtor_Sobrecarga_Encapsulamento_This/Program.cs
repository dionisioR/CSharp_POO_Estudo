
using System;

// Define namespace for the program.
namespace _02_Construtor_Sobrecarga_Encapsulamento_This {
    // Define the Main method, which is the entry point for the application.
    public class Program {
        public static void Main(string[] args) {


            //Console.WriteLine("Entre com os dados do produto: ");
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //double preco = double.Parse(Console.ReadLine());
            //Console.Write("Quantidade: ");
            //int quantidade = int.Parse(Console.ReadLine());
            //Produto p = new Produto(nome, preco, quantidade);
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Dados do produto:");
            //Console.WriteLine("---------------------------");
            //Console.WriteLine(p);
            //Console.WriteLine($"Valor total em estoque: R${p.ValotTotalEmEstoque().ToString("F2")}");
            //Console.WriteLine("---------------------------\n");
            //Console.WriteLine("---------------------------\n");

            //-------------------------------------------------------------------------------------------

            //Console.WriteLine("Entre com os dados do produto: ");
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //double preco = double.Parse(Console.ReadLine());
            //Console.Write("Quantidade: ");
            //int quantidade = int.Parse(Console.ReadLine());
            //ProdutoSobrecarga p = new ProdutoSobrecarga(nome, preco, quantidade);
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Dados do produto:");
            //Console.WriteLine("---------------------------");
            //Console.WriteLine(p);
            //Console.WriteLine($"Valor total em estoque: R${p.ValotTotalEmEstoque().ToString("F2")}");
            //Console.WriteLine("---------------------------\n");
            //Console.WriteLine("---------------------------\n");

            //Console.WriteLine("Entre com os dados do produto: ");
            //Console.Write("Nome: ");
            //nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //preco = double.Parse(Console.ReadLine());
            //ProdutoSobrecarga p2 = new ProdutoSobrecarga(nome, preco);
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Dados do produto:");
            //Console.WriteLine("---------------------------");
            //Console.WriteLine(p2);
            //Console.WriteLine($"Valor total em estoque: R${p2.ValotTotalEmEstoque().ToString("F2")}");
            //Console.WriteLine("---------------------------\n");
            //Console.WriteLine("---------------------------\n");

            //-------------------------------------------------------------------------------------------

            // Sintaxe Alternativa para instanciar um objeto
            // Pode ser utilizada para inicializar os valores quando não temos os construtores
            // Ou quando temos o contrutor padrão


            /*
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string _nome = Console.ReadLine();
            Console.Write("Preço: ");
            double _preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int _quantidade = int.Parse(Console.ReadLine());

            ProdutoSobrecarga p3 = new ProdutoSobrecarga {
                nome = _nome,
                preco = _preco,
                quantidade = _quantidade
            };
            Console.WriteLine(p3);
            */

            //----------------------------------------
            // PROPERTIES
            //----------------------------------------
            //Properties p = new Properties("TV", 900.33, 2);
            //Console.WriteLine(p);
            //p.Nome = "Rádio";
            //Console.WriteLine(p);

            //----------------------------------------
            // AUTO PROPERTIES
            //----------------------------------------
            AutoProperties p = new AutoProperties("TV", 900.33, 2);
            Console.WriteLine(p);
            p.Nome = "Rádio";
            Console.WriteLine(p);
        }
    }
}