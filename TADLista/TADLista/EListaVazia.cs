using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADLista
{
    class EListaVazia : Exception
    {
        public EListaVazia(string message) : base(message)
        {
        }
    }
}
