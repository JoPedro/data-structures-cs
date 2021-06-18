using System;

namespace StackDataStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            PilhaRBArray pilha = new PilhaRBArray();

            pilha.PushRed("a");
            
            // Testando alguns comandos
            Console.WriteLine("[{0}]", string.Join(separator: ", ", pilha.TestArray()));
            Console.WriteLine(pilha.Size());
            Console.WriteLine(pilha.TopRed());
            Console.WriteLine(pilha.PopRed());
            Console.WriteLine("[{0}]", string.Join(separator: ", ", pilha.TestArray()));
            pilha.PushRed("A");

            pilha.PushBlack(1);

            Console.WriteLine("[{0}]", string.Join(separator: ", ", pilha.TestArray()));
            Console.WriteLine(pilha.Size());
            Console.WriteLine(pilha.TopBlack());
            Console.WriteLine(pilha.PopBlack());
            Console.WriteLine("[{0}]", string.Join(separator: ", ", pilha.TestArray()));

            // Testando a expansão dinâmica
            for (int i = 0; i < 40; ++i)
            {
                if (i % 2 == 0)
                    pilha.PushRed(i << 1);
                else
                    pilha.PushBlack('a' + i);
            }

            Console.WriteLine("[{0}]", string.Join(separator: ", ", pilha.TestArray()));
        }
    }
}
