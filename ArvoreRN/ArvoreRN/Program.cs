using System;

namespace ArvoreRN
{
    class Program
    {
        static void Main(string[] args)
        {
            ArvoreRN tree = new ArvoreRN();

            tree.Inserir(30);
            tree.Mostrar();
            Console.WriteLine();
            Console.WriteLine("=============");
            tree.Inserir(13);
            tree.Mostrar();
            Console.WriteLine();
            Console.WriteLine("=============");
            tree.Inserir(53);
            tree.Mostrar();
            Console.WriteLine();
            Console.WriteLine("=============");
            tree.Inserir(8);
            tree.Mostrar();
            Console.WriteLine();
            Console.WriteLine("=============");
            tree.Inserir(23);
            tree.Mostrar();
            Console.WriteLine();
            Console.WriteLine("=============");
            tree.Inserir(43);
            tree.Mostrar();
            Console.WriteLine();
            Console.WriteLine("=============");
            tree.Inserir(83);
            tree.Mostrar();
            Console.WriteLine();
            Console.WriteLine("=============");
            tree.Inserir(63);
            tree.Mostrar();
            Console.WriteLine();
            Console.WriteLine("=============");
            tree.Inserir(93);
            tree.Mostrar();
            Console.WriteLine();
            Console.WriteLine("=============");
            tree.Inserir(96);
            tree.Mostrar();
        }
    }
}
