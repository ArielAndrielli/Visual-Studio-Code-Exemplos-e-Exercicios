using System;
using System.Globalization;

namespace Estrutura_Repetitiva_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type in a number: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            while (x >= 1.0) {

            double raiz = Math.Sqrt(x);
            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));     
            Console.Write("Type in another number: ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
             if(x == 0) {
                System.Console.WriteLine("Zero does not compute!");
            }
            if(x < 0){
            System.Console.WriteLine("Negative Term!");
            }
        }
    }
}
