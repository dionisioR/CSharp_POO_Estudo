using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Arrays_Listas {
    internal class Listas_03 {

        public static void Executar() {

            Console.Write("Quantos funcionários deseja cadastrar? ");
            int qtd = int.Parse(Console.ReadLine());

            List<Funcionario> listFunc = new List<Funcionario>();

            for (int i = 0; i < qtd; i++) {
                Console.Write($"Digite o ID do funcionário {i + 1}: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write($"Digite o NOME do funcionário {i + 1}: ");
                string nome = Console.ReadLine();
                Console.Write($"Digite o SALÁRIO do funcionário {i + 1}: ");
                double cargo = double.Parse(Console.ReadLine());
                listFunc.Add(new Funcionario(id, nome, cargo));
                Console.WriteLine();
            }

            Console.WriteLine("Digite o ID do Funcionário");
            int idFunc = int.Parse(Console.ReadLine());

            Funcionario func = listFunc.Find(f => f.Id == idFunc);

            if (func != null) {
                Console.Write("Digite a porcentagem de aumento do salário: ");
                double porcentagem = double.Parse(Console.ReadLine());
                func.IncrementarSalario(porcentagem);
            }
            else {
                Console.WriteLine("Id NÃO encontrado....");
            }
            Console.WriteLine();
            foreach (var item in listFunc) {
                Console.WriteLine(item);
            }
        }
    }
}
