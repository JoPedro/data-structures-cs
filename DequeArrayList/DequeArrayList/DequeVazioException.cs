using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DequeArrayList
{
    class DequeVazioException : Exception
    {
        public DequeVazioException(string message) : base(message)
        {
        } 
    }
}
