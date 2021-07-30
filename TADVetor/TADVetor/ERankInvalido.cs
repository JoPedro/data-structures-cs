using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADVetor
{
    public class ERankInvalido : Exception
    {
        public ERankInvalido(string message) : base(message)
        {
        }
    }
}
