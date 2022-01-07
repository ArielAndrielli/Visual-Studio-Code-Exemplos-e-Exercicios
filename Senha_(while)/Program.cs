using System;

namespace Senha__while_
{
    class Program
    {
        static void Main(string[] args)
        {
            string pw = "senhalegal";

            Console.WriteLine("User");
            string user = Console.ReadLine();
            Console.WriteLine("Password: ");
            pw = Console.ReadLine();

            while (pw != "senhalegal") {
                System.Console.WriteLine("Wrong Passaword, try again: ");
                pw = Console.ReadLine();
            }
            System.Console.WriteLine("Correct, welcome " + user);

        }
    }
}
