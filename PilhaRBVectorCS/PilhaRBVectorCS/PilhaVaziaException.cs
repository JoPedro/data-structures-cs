using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaRBVectorCS
{
    public class PilhaVaziaException : Exception
    {
        public PilhaVaziaException(string message) : base(message)
        {
        }
    }
}
