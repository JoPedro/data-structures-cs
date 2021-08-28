using System;

namespace TADFilaPrioridadeHeapArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testes
            FilaPrioridadeHeapArray fp = new FilaPrioridadeHeapArray();
            Console.WriteLine(fp.Size());
            Console.WriteLine(fp.IsEmpty());

            fp.Inserir(2, "A");
            fp.Inserir(6, "C");
            fp.Inserir(5, "B");
            fp.Inserir(9, "E");
            fp.Inserir(7, "D");

            Console.WriteLine(fp.Size());
            Console.WriteLine(fp.IsEmpty());

            fp.Teste();
        }
    }
}
