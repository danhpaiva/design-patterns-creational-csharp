using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tPadrão Singleton\n");

            Console.WriteLine("Tentando criar uma instância s1...");
            Singleton s1 = Singleton.Instance;

            Console.WriteLine("Tentando criar uma instância s2...");
            Singleton s2 = Singleton.Instance;

            if (s1 == s2)
                Console.WriteLine("Existe somente uma instância.");
            else
                Console.WriteLine("Existem instâncias diferentes.");

            Console.ReadLine();
        }
    }
}
