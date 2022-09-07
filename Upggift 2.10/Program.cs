using System;

namespace Uppgift_210
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken bok är din favoritbok?");
            Console.Write("Skriv här: "); string svar = Console.ReadLine();
            Console.WriteLine("Din favoritbok är alltså " + svar + ".");
        }
    }
}
