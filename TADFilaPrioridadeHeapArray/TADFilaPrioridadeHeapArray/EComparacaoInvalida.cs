using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADFilaPrioridadeHeapArray
{
    class EComparacaoInvalida : Exception
    {
        public EComparacaoInvalida(string message) : base(message)
        {
        }
    }
}
