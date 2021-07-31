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
                string s = "Elem " + i.ToString();
                vetor.InsertAtRank(i, s);
            }

            PrintarVetor();

            for (int i = 0; i < 20; ++i)
                vetor.RemoveAtRank(i * 2);

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
            Console.Write("}\n\n");
        }
    }
}
