using System;
using Func;
using System.Globalization;

namespace Exercício_Classe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario a, b;

            a = new Funcionario();
            b = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            a.nome = Console.ReadLine();
            a.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Segundo funcionário: ");
            b.nome = Console.ReadLine();
            b.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (a.salario + b.salario) / 2;

            System.Console.WriteLine("Média Salarial: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
