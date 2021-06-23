using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaArray
{
    class TesteFila
    {
        // Classe de testes implemente métodos estáticos com váriaveis locais que testam os métodos de TADFila
        public static object[] TestQueue()
        {
            TADFila f = new TADFila(7);
            for (int i = 0; i < 99; ++i)
                f.Queue(i << 1);
            return f.TestFila();
        }

        public static object TestDequeue()
        {
            TADFila f = new TADFila(3);
            f.Queue("FIRST OUT! Não existe mais.");
            for (int i = 0; i < 99; ++i)
                f.Queue(i << 1);
            return f.Dequeue();
        }

        public static object TestFirst()
        {
            TADFila f = new TADFila(4);
            f.Queue("FIRST!");
            for (int i = 0; i < 99; ++i)
                f.Queue(i << 1);
            return f.First();
        }
    }
}
