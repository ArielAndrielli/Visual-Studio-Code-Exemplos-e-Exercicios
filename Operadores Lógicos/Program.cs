using System;

namespace Operadores_Lógicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 && 4 != 5;
            bool c2 = 2 > 3 || 4 != 5;
            bool outro = !(2 > 3) && 4 != 5;
            bool c3 = 10 < 5;
            bool c4 = c1 || c2 && c3;
            System.Console.WriteLine("Primeiro: ");
            System.Console.WriteLine(c1);
            System.Console.WriteLine("Segundo: ");
            System.Console.WriteLine(c2);
            System.Console.WriteLine("Outro: ");
            System.Console.WriteLine(outro);
            System.Console.WriteLine("Terceiro: ");
            System.Console.WriteLine(c3);
            System.Console.WriteLine("Quarto: ");
            System.Console.WriteLine(c4);
        }
    }
}
