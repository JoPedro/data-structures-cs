using System;

namespace LinkedListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testando lista simplesmente encadeada: 
            Console.WriteLine("Teste de Lista Simplesmente Encadeada manual:");
            Console.WriteLine();

            LinkedListTest lista = new LinkedListTest(0);
            for (int i = 1; i < 25; ++i)
                lista.Append(i * 5);

            Console.Write("Lista inteira: ");
            lista.PrintList();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Retornando os dados do Node de índice 4: ");
            Console.WriteLine(lista.Get(4).data);
            Console.WriteLine();
            Console.WriteLine();

            lista.InsertAt(4, "Vinte");
            lista.PrintList();

            Console.WriteLine("\n");
            Console.WriteLine("Tamanho da lista: " + lista.Size());
        }
    }
}
