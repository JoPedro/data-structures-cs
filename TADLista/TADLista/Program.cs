using System;

namespace TADLista
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testando lista simplesmente encadeada: 
            Console.WriteLine("Teste de Lista Simplesmente Encadeada manual:");
            Console.WriteLine();

            ListaDuplamenteLigada lista = new ListaDuplamenteLigada();
            for (int i = 0; i < 5; ++i)
                lista.Append(i * 5);
            
            Console.Write("Lista inteira: ");
            lista.PrintList();
            Console.WriteLine("\n");
            Console.WriteLine("Tamanho: " + lista.Size());
            Console.WriteLine("Head: " + lista.head.Data);
            Console.WriteLine("Tail: " + lista.tail.Data);
            Console.WriteLine();

            // Testando insertat
            ListaDuplamenteLigada lista2 = new ListaDuplamenteLigada();
            for (int i = 0; i < 5; ++i)
                lista2.InsertAt(i, i * 3);

            lista2.InsertAt(2, 3);

            Console.Write("Lista inteira: ");
            lista2.PrintList();
            Console.WriteLine("\n");
            Console.WriteLine("Tamanho: " + lista2.Size());
            Console.WriteLine("Head: " + lista2.head.Data);
            Console.WriteLine("Tail: " + lista2.tail.Data);
            Console.WriteLine();

            /*Console.Write("Retornando os dados do Node de índice 4: ");
            Console.WriteLine(lista.Get(4).data);
            Console.WriteLine();
            Console.WriteLine();

            lista.InsertAt(4, "Vinte");
            lista.PrintList();

            Console.WriteLine("\n");
            Console.WriteLine("Tamanho da lista: " + lista.Size());*/
        }
    }
}
