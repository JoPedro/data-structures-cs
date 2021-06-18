using System;

namespace PilhaRBVectorCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utilizando métodos estáticos da classe teste no programa
            foreach (object elem in TestePilha.PushTest())
            {
                Console.Write(elem.ToString());
                Console.Write(", ");
            }
            Console.WriteLine("\n");
            Console.WriteLine(TestePilha.TestTop());
            Console.WriteLine(TestePilha.TestPop());
        }
    }
}
