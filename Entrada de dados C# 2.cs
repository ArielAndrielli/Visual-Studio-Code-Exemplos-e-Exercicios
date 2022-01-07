using System;
using System.Globalization;

ConsoleApplication2{
    class Program{
        static void main(string[] args) {

            int numint;
            string caract;
            double numcomp;

            System.Console.WriteLine("Type in an integer: ");
            int.Parse(Console.ReadLine(numint));
            System.Console.WriteLine("Type in some letters: ");
            Console.ReadLine(caract);
            System.Console.WriteLine("Type in a decimal number: ");
            Console.ReadLine(numcomp);

            System.Console.WriteLine("What you typed: ");
            System.Console.WriteLine(numint);
            System.Console.WriteLine(caract);
            System.Console.WriteLine(numcomp);


            System.Console.WriteLine("Type a name, sex, integer and a decimal number: ");
            string[] vet = Console.ReadLine().Split(' ');
            string name = vet [0];
            char sex = vet [1];
            int inteiro = vet [2];
            double composto = vet [3];

        }
    }
}