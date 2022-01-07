using System;
using System.Globalization;
namespace Divisão__for_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos pares deseja informar? ");
            int N = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Informe o(s) par(es) de números para a divisão: ");

            for(int i = 1; i <= N; i++) {

            string[] vet = Console.ReadLine().Split(' ');
            int n1 = int.Parse(vet [0]);
            int n2 = int.Parse(vet [1]);
            if(n2 == 0) {
                System.Console.WriteLine("Divisão Impossível!");
            }else{
                System.Console.Write("Resultado: ");
                double div = (double)n1 / n2;
                Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
            }

                
            }

        }
    }
}
