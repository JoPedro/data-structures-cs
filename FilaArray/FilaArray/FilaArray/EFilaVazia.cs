using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaArray
{
    class EFilaVazia : Exception
    {
        public EFilaVazia(string message) : base(message)
        {
        }
    }
}
