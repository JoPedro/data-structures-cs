using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADLista
{
    class TADLista : ITADLista
    {
        private ListaDuplamenteLigada lista;

        public TADLista()
        {
            lista = new ListaDuplamenteLigada();
        }

        public void ReplaceElement(Node n, object o)
        {
            n.Data = o;
        }

        public void SwapElements(Node n, Node m)
        {
            object o = n.Data;
            n.Data = m.Data;
            m.Data = o;
        }

        public void InsertBefore(Node n, object o)
        {
            Node noAnterior = n.prev;
            Node newNode = new Node(o);
            n.prev = newNode;
            noAnterior.next = newNode;

            newNode.prev = noAnterior;
            newNode.next = n;
        }
    }
}
