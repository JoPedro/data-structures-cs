using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaRBVectorCS
{
    interface IPilhaVector
    {
        public object Top();
        public void Push(object o);
        public object Pop();
        public int Size();
        public bool IsEmpty();
    }
}
