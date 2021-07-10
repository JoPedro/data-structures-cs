using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DequeArrayList
{
    class TesteDeque
    {
        public static void TestInserirInicio()
        {
            TADDeque f = new TADDeque(7);
            for (int i = 0; i < 99; ++i)
                f.InserirInicio(i << 1);
            f.Mostrar();
        }

        public static void TestInserirFim()
        {
            TADDeque f = new TADDeque(7);
            for (int i = 0; i < 10; ++i)
                f.InserirInicio(i << 1);

            for (int i = 0; i < 99; ++i)
                f.InserirFim(i << 1);
            f.Mostrar();
        }

        public static object TestRemoverInicio()
        {
            TADDeque f = new TADDeque(3);
            f.InserirInicio("FIRST OUT! Não existe mais.");
            for (int i = 0; i < 99; ++i)
                f.InserirInicio(i << 1);
            return f.RemoverInicio();
        }

        public static object TestRemoverFim()
        {
            TADDeque f = new TADDeque(3);
            for (int i = 0; i < 10; ++i)
                f.InserirInicio(i << 1);

            for (int i = 0; i < 99; ++i)
                f.InserirFim(i << 1);
            f.InserirFim("LAST OUT! Não existe mais.");

            return f.RemoverFim();
        }

        public static object TestFirst()
        {
            TADDeque f = new TADDeque(4);
            f.InserirInicio("FIRST!");
            for (int i = 0; i < 99; ++i)
                f.InserirInicio(i << 1);
            return f.First();
        }

        public static object TestLast()
        {
            TADDeque f = new TADDeque(5);
            for (int i = 0; i < 10; ++i)
                f.InserirInicio(i << 1);

            for (int i = 0; i < 99; ++i)
                f.InserirFim(i << 1);

            f.InserirFim("LAST!");
            return f.Last();
        }
    }
}
