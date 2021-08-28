using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADFilaPrioridadeHeapArray
{
    class TADComparadorNumero
    {
        public static int Compare(Item i, Item k)
        {
            int a = (int)i.Key();
            int b = (int)k.Key();
            if (a < b) return -1;
            else if (a == b) return 0;
            else if (a > b) return 1;
            else { throw new EComparacaoInvalida("Os itens não podem ser comparados como números inteiros."); }
        }
    }
}
