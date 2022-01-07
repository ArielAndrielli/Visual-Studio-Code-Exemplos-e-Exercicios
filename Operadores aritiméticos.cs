ConsoleApplication2 {
    class Program {
        static void Main(string[] args) {

            int n1 = 3 + 4 * 5;
            int n2 = (3 + 4) * 5;
            int n3 = 17 % 3;
            double n4 = (double) 10 / 8;
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = (Math.Pow(b, 2.0)) - (4.0 * a * c);

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            System.Console.WriteLine(n1);
            System.Console.WriteLine(n2);
            System.Console.WriteLine(n3);
            System.Console.WriteLine(n4);
            System.Console.WriteLine(delta);
            System.Console.WriteLine(x1);
            System.Console.WriteLine(x2);
        }
    }
}
