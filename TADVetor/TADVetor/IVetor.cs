using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADVetor
{
    public interface IVetor
    {
        public object ElemAtRank(int r);
        public object ReplaceAtRank(int r, object o);
        public void InsertAtRank(int r, object o);
        public object RemoveAtRank(int r);
        public int Size();
        public bool IsEmpty();
    }
}
