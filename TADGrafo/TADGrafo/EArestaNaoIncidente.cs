using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADGrafo
{
    class EArestaNaoIncidente : Exception
    {
        public EArestaNaoIncidente(string message) : base(message)
        {
        }
    }
}
