using System;

namespace Numeros_Impares__for_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número para calcular seus respectivos termos ímpares: ");
            int N = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= N; i++) {
                if(i % 2 != 0) {
                    Console.Write(i);
                }
            }

        }
    }
}
