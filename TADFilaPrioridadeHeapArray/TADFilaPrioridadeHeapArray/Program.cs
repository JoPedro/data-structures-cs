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

            fp.Inserir(2, "2");
            fp.Inserir(6, "6");
            fp.Inserir(5, "5");
            fp.Inserir(9, "9");
            fp.Inserir(7, "7");

            Console.WriteLine(fp.Size());
            Console.WriteLine(fp.IsEmpty());

            fp.Teste();
        }
    }
}
