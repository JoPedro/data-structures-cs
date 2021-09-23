using System;

namespace TADHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testes de TADHashTable:\n\n");

            Console.WriteLine("Teste com Linear Probing:\n");
            TesteHashTable teste = new TesteHashTable();
            teste.TesteLinearProbing();
            Console.WriteLine("\n\n");

            Console.WriteLine("Teste com Hashing Duplo:\n");
            TesteHashTable teste2 = new TesteHashTable();
            teste2.TesteHashingDuplo();
            Console.WriteLine();
        }
    }
}
