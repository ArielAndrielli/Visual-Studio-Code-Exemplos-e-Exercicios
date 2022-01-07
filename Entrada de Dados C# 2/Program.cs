using System;
using System.Globalization;

namespace Course{ 
    class Program{
        static void Main(string[] args) {

            Console.WriteLine("Type in an integer: ");
            int numint = int.Parse(Console.ReadLine());
            Console.WriteLine("Type in some letters: ");
            string caract = Console.ReadLine();
            Console.WriteLine("Type in a decimal number: ");
            double numcomp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Type a name, sex, integer and a decimal number: ");
            string[] vet = Console.ReadLine().Split(' ');
            string name = vet[0];
            char sex = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("What you typed: ");
            Console.WriteLine(numint);
            Console.WriteLine(caract);
            Console.WriteLine(numcomp.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("-------------------------");
            Console.WriteLine(name);
            Console.WriteLine(sex);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}