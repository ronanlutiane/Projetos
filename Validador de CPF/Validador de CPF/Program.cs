using System;

namespace Validador_de_CPF
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0, dig1, dig2;
            Console.WriteLine("Digite um numero de CPF (Apenas numeros)");
            String cpf = Console.ReadLine();
            //Console.WriteLine("CPF digitado = " + cpf);
            if (cpf.Length != 11)
            {
                Console.WriteLine("CPF inválido!");
            }
            string iniciocpf = cpf.Substring(0, 9);
            Console.WriteLine(iniciocpf);
            int[] tabela1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] tabela2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(iniciocpf[i].ToString()) * tabela1[i]; // iniciocpf[i] indexa o caracter na posiçao i da string iniciocpf
            }
            if (soma % 11 < 2)
            {
                dig1 = 0;
            }
            else
            {
                dig1 = 11 - (soma % 11);
            }
            Console.WriteLine("Primeiro Dígito = " + dig1);
            String inicioCpf2 = cpf.Substring(0, 10);
            Console.WriteLine(inicioCpf2);
             if (int.Parse(inicioCpf2[10].ToString()) == dig1) // inicioCpf2[10] agora indexa o caracter na posiçao 10 da string inicioCpf2
            {
                for (int j = 0; j < 10; j++)
                {
                    soma += int.Parse(inicioCpf2[j].ToString()) * tabela2[j];
                }
                if (soma % 11 < 2)
                {
                    dig2 = 0;
                }
                else
                {
                    dig2 = 11 - (soma % 11);
                }
                if (int.Parse(cpf[11].ToString()) == dig2)
                {
                    Console.WriteLine("CPF Válido");
                }
            }
            else
            {
                Console.WriteLine("CPF inválido!");
            }
        }
    }
}
