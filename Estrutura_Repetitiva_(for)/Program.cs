using System;

namespace Estrutura_Repetitiva__for_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;
            System.Console.WriteLine("Digite os números desejados: ");

            //i++ and i = i + 1 are the same concept
            for(int i = 1; i <= N; i++) {
                Console.WriteLine("Nº #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor; //soma += valor also works
            }
            System.Console.WriteLine("A soma é: " + soma);

        }
    }
}
