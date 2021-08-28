using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADFilaPrioridadeHeapArray
{
    class Item : IItem
    {
        private int numero;
        private object valor;

        public Item(int numero, object valor)
        {
            this.numero = numero;
            this.valor = valor;
        }

        public object Key()
        {
            return numero;
        }

        public object Value()
        {
            return valor;
        }

        public void SetValue(object o)
        {
            valor = o;
        }
    }
}
