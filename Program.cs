using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0, valor2 = 1;
            int termo;
            bool termoValido;
            int soma;
            string op;

            do
            {
                Console.Write("Digite a Quantidade de Termos: ");
                termoValido = int.TryParse(Console.ReadLine(), out termo);

                if (!termoValido)
                {
                    Console.WriteLine();
                    Console.WriteLine("Você digitou um valor invalido!");
                    Console.WriteLine("Pressione ENTER para sair e execute o programa novamente");
                    Console.ReadKey();
                    Environment.Exit(-1);
                }

                soma = valor1 + valor2;

                Console.WriteLine();
                Console.Write(0 + " " + 1 + " ");

                for (int i = 3; i <= termo; i++)
                {
                    Console.Write(soma + " ");
                    valor1 = valor2;
                    valor2 = soma;
                    soma = valor1 + valor2;
                }

                Console.WriteLine();
                Console.Write("Deseja Sair? S/N: ");
                op = Console.ReadLine().ToUpper();
            }
            while (op == "N" || op == "NAO");
            {
                Console.WriteLine();
                Console.WriteLine("Obrigado por utilizar meu programa :)");
                Environment.Exit(-1);
            }
        }
    }
}
       
