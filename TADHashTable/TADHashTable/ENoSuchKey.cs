using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADHashTable
{
    class ENoSuchKey : Exception
    {
        public ENoSuchKey(string message) : base(message)
        {
        }
    }
}
