using System;
using Person;

namespace Exercício_Classe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa x, y;

            x = new Pessoa();
            y = new Pessoa();

            System.Console.WriteLine("Dados da primeira pessoa: ");

            x.nome = Console.ReadLine();
            x.idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Dados da segunda pessoa: ");

            y.nome = Console.ReadLine();
            y.idade = int.Parse(Console.ReadLine());

            if(x.idade > y.idade) {
                System.Console.WriteLine("A pessoa mais velha é: " + x.nome);
            }else{
                System.Console.WriteLine("A pessoa mais velha é: " + y.nome);
            }
        }
    }
}
