using System;

namespace Funções__sintaxe_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números inteiros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            //sem função
            //if(n1 > n2 && n1 > n3) {
            //    System.Console.WriteLine(n1 + " é o maior termo!");
            //} else if(n2 > n1 && n2 > n3) {
            //    System.Console.WriteLine(n2 + " é o maior termo!");
            //} else if(n3 > n1 && n3 > n2) {
            //    System.Console.WriteLine(n3 + " é o maior termo!");
            //} else if(n1 == n2 && n1 == n3) {
            //    System.Console.WriteLine("Todos os termos são iguais!");
            //} else if(n1 > n2 && n1 == n3) {
            //    System.Console.WriteLine("Os dois números " + n3 + " são os maiores termos!");
            //} else if(n1 > n3 && n1 == n2) {
            //    System.Console.WriteLine( "Os dois números " + n2 + " são os maiores termos!");
            //}

            //com função
            double resultado = Maior(n1, n2, n3);

            System.Console.WriteLine("Maior = " + resultado);
        }

        //função
        static int Maior(int a, int b, int c) {
        int m;
        if (a > b && a > c) {
            m = a;
        } else if (b > c) {
            m = b;
        }
          else{
            m = c;
        }

        return m;
        }
    }
}
