using System;
using System.Globalization;
namespace sem_o.o
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Informe as medidas do triângulo X: ");

            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe as medidas do triângulo Y");

            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * xA) * (p - xB) * (p - xC);

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * yA) * (p - yB) * (p - yC);

            System.Console.WriteLine("Área X: " + areaX.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Área Y: " + areaY.ToString("F2", CultureInfo.InvariantCulture));

            if(areaX > areaY) {
                System.Console.WriteLine("Maior Área: Triângulo X");
            }else{
                System.Console.WriteLine("Maior Área: Triângulo Y");
            }

        }

    }
}
