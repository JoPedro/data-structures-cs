using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDataStruct
{
    interface PilhaRubroNegra
    {
        public int Size();
        public bool IsEmpty();
        public object[] Top();
        public void Push(object o);
        public object Pop();
    }
}
