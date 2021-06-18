using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaRBVectorCS
{
    class TestePilha
    {
        // Classe de testes implemente métodos estáticos com váriaveis locais que testam os métodos de TADPilha
        public static ArrayList PushTest()
        {
            TADPilha arr = new TADPilha();
            for (int i = 1; i < 99; ++i)
                arr.Push(i << 1);
            return arr.GetVector();
        } 

        public static object TestTop()
        {
            TADPilha arr = new TADPilha();
            for (int i = 0; i < 12; ++i)
                arr.Push('A' + i);
            arr.Push("TOP!");
            return arr.Top();
        }

        public static object TestPop()
        {
            TADPilha arr = new TADPilha();
            for (int i = 0; i < 16; ++i)
                arr.Push('Z' + i);
            arr.Push("POP! Este elemento não está mais entre nós.");
            return arr.Pop();
        }
    }
}
