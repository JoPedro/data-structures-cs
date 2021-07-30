using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADVetor
{
    public class EVetorVazio : Exception
    {
        public EVetorVazio(string message) : base(message)
        {
        }
    }
}
