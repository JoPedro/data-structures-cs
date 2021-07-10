using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DequeArrayList
{
    interface IDeque
    {
        public void InserirInicio(object o);
        public void InserirFim(object o);
        public object RemoverInicio();
        public object RemoverFim();
        public object First();
        public object Last();
        public int Size();
        public bool IsEmpty();
        public void Mostrar();
    }
}
