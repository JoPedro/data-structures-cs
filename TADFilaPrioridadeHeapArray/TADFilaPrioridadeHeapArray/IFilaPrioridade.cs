using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADFilaPrioridadeHeapArray
{
    interface IFilaPrioridade
    {
        public void Inserir(object k, object o);
        public Item RemoveMin();
        public Item Min();
        public int Size();
        public bool IsEmpty();
    }
}
