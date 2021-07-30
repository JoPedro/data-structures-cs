using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADVetor
{
    public class TesteVetor
    {
        private TADVetor vetor;

        public TesteVetor()
        {
            vetor = new TADVetor();
        }

        public void Teste()
        {
            for (int i = 0; i < 99; ++i)
            {
                char c = (char)65;
                vetor.InsertAtRank(i, 91 + c);
            }

            PrintarVetor();

            for (int i = 0; i < 3; ++i)
                vetor.RemoveAtRank(i * 3);

            PrintarVetor();

            vetor.ReplaceAtRank(0, "REPLACED");

            PrintarVetor();
        }

        public void PrintarVetor()
        {
            Console.Write("{");
            for (int i = 0; i < vetor.Size(); ++i)
            {
                Console.Write(vetor.ElemAtRank(i) + ", ");
            }
            Console.Write("}");
            Console.WriteLine();
        }
    }
}
