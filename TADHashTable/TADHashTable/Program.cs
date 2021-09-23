using System;

namespace TADHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testes de TADHashTable:\n");

            TesteHashTable teste = new TesteHashTable();
            teste.TesteLinearProbing();
        }
    }
}
