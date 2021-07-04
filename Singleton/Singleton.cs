using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance;
        private int numberOfInstances = 0;

        private Singleton()
        {
            Console.WriteLine("Instanciando dentro do construtor privado.\n");
            numberOfInstances++;
            Console.WriteLine($"Número de Instâncias: {numberOfInstances}\n");
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    Console.WriteLine($"Criando a primeira instância.\n");
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
