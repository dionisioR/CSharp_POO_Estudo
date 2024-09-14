using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Funcoes_Especiais {
    internal class String_01 {

        public static void Executar() {
            string original = "abcde ABCED abc ABC def  ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            // Substring - corta uma parte da string
            // string s4 = original.Substring(indice_inicial, quantidade_de_caracteres);
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);

            // Replace - substitui caracteres da string
            string s6 = original.Replace("abc", "XYZ");
            string s7 = original.Replace("abc", "XYZ", StringComparison.OrdinalIgnoreCase);

            // Verifica se uma string é nula ou vazio
            string nula = null;
            string vazia = "";
            string espaco = "  ";

            bool isEmpty1 = string.IsNullOrEmpty(original);
            bool isEmpty2 = string.IsNullOrEmpty(nula);
            bool isEmpty3 = string.IsNullOrEmpty(vazia);
            bool isEmpty4 = string.IsNullOrEmpty(espaco);
            

            bool isWhiteSpace1 = string.IsNullOrWhiteSpace(original);
            bool isWhiteSpace2 = string.IsNullOrWhiteSpace(nula);
            bool isWhiteSpace3 = string.IsNullOrWhiteSpace(vazia);
            bool isWhiteSpace4 = string.IsNullOrWhiteSpace(espaco);

            // Split
            string[] words = original.Split(' ');
            

            Console.WriteLine($"Original: {original}-");
            Console.WriteLine($"ToUpper: {s1}-");
            Console.WriteLine($"ToLower: {s2}-");
            Console.WriteLine($"Trim: {s3}-");
            Console.WriteLine($"IndexOf('bc'): {n1}");
            Console.WriteLine($"LastIndexOf('bc'): {n2}");
            Console.WriteLine($"Substring: {s4}");
            Console.WriteLine($"Substring: {s5}");
            Console.WriteLine($"Replace('abc', 'XYZ'): {s6}-");
            Console.WriteLine($"Replace('abc', 'XYZ', StringComparison.OrdinalIgnoreCase): {s7}-");
            Console.WriteLine("-------------");
            Console.WriteLine($"IsNullOrEmpty(original): {isEmpty1}");
            Console.WriteLine($"IsNullOrEmpty(nula): {isEmpty2}");
            Console.WriteLine($"IsNullOrEmpty(vazia): {isEmpty3}");
            Console.WriteLine($"IsNullOrEmpty(espaco): {isEmpty4}");
            Console.WriteLine("-------------");
            Console.WriteLine($"IsNullOrWhiteSpace(original): {isWhiteSpace1}");
            Console.WriteLine($"IsNullOrWhiteSpace(nula): {isWhiteSpace2}");
            Console.WriteLine($"IsNullOrWhiteSpace(vazia): {isWhiteSpace3}");
            Console.WriteLine($"IsNullOrWhiteSpace(espaco): {isWhiteSpace4}");
            Console.WriteLine("-------------");
            Console.WriteLine($"words : ${words[0]} - ${words[1]} - ${words[2]}");
            Console.WriteLine("-------------");

            // Conversão
            string numero = "1234";
            int num_1 = int.Parse( numero );
            Console.WriteLine(num_1);
            int num_2 = Convert.ToInt32( numero );
            Console.WriteLine(num_2);
            Console.WriteLine("-------------");

            // convertendo numero para string
            string s8 = num_1.ToString();
            string s9 = num_1.ToString("C");
            string s10 = num_1.ToString("C3");
            string s11 = num_1.ToString("F2");
            string s12 = num_1.ToString("F3");
            Console.WriteLine(s8);
            Console.WriteLine(s9);
            Console.WriteLine(s10);
            Console.WriteLine(s11);
            Console.WriteLine(s12);       

        }
    }
}
