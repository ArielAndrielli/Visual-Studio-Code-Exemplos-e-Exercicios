using System;

namespace Estrutura_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0) {
                System.Console.WriteLine("Even!");
            }else{
                System.Console.WriteLine("Odd!");
            }

            Console.WriteLine("Digite a hora:" );
            int hora = int.Parse(Console.ReadLine());

            if(hora < 12) {
                System.Console.WriteLine("Good Morning!");
            }else if (hora >= 12 && hora < 18) {
                System.Console.WriteLine("Good Afternoon!");
            }else if(hora >= 18 && hora <= 24) {
                System.Console.WriteLine("Good Night!");
            }else{
                System.Console.WriteLine("Invalid Time!!!");
            }

            System.Console.WriteLine("Digite um número inteiro: ");
            int n2 = int.Parse(Console.ReadLine());

            if(n2 < 0) {
                System.Console.WriteLine("Negative!");
            }else if(n2 > 0) {
                System.Console.WriteLine("Positive!");
            }else{
                System.Console.WriteLine("Neutral!");
            }

        }
    }
}
