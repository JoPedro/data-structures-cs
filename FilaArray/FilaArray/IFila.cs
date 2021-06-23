using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaArray
{
    interface IFila
    {
        public int Size();
        public bool IsEmpty();
        public object First();
        public void Queue(object o);
        public object Dequeue();
    }
}
