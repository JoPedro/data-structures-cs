using System;

namespace FilaArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utilizando métodos estáticos da classe teste no programa
            foreach (object elem in TesteFila.TestQueue())
            {
                if (elem != null) Console.Write(elem.ToString());
                Console.Write(", ");
            }
            Console.WriteLine("\n");
            Console.WriteLine(TesteFila.TestFirst());
            Console.WriteLine(TesteFila.TestDequeue());
        }
    }
}
