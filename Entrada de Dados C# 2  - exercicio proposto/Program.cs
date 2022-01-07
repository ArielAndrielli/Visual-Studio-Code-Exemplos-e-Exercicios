using System;
using System.Globalization;

namespace Entrada_de_Dados_C__2____exercicio_proposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your full name (max 3 names): ");
            string[] vector = Console.ReadLine().Split(" ");
            string name = vector[0];
            string name2 = vector[1];
            string name3 = vector[2];
            Console.WriteLine("How many rooms does your house have?: ");
            string room = Console.ReadLine();
            Console.WriteLine("Insert a product price: ");
            string price = Console.ReadLine();
            Console.WriteLine("Insert your last name, age and heigh (on the same line): ");
            string[] vet = Console.ReadLine().Split(" ");
            string last = vet[0];
            int age = int.Parse(vet[1]);
            double heigh = double.Parse(vet[2], CultureInfo.InvariantCulture);

            System.Console.WriteLine("------Your data------");
            System.Console.WriteLine(name, name2, name3);
            System.Console.WriteLine(room);
            System.Console.WriteLine(price);
            System.Console.WriteLine(last);
            System.Console.WriteLine(age);
            System.Console.WriteLine(heigh);
        }
    }
}
