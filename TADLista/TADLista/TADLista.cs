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

        public void InsertAfter(Node n, object o)
        {
            Node noProximo = n.next;
            Node newNode = new Node(o);
            n.next = newNode;
            noProximo.prev = newNode;

            newNode.next = noProximo;
            newNode.prev = n;
        }

        public void InsertFirst(object o)
        {
            lista.AddBeginning(o);
        }

        public void InsertLast(object o)
        {
            lista.Append(o);
        }
        
        public Node Remove(Node n)
        {
            n.prev.next = n.next;
            n.next.prev = n.prev;
            return n;
        }

        public Node Before(Node n)
        {
            return n.prev;
        }

        public Node After(Node n)
        {
            return n.next;
        }

        public Node First()
        {
            return lista.head;
        }

        public Node Last()
        {
            return lista.tail;
        }

        public bool IsFirst(Node n)
        {
            if (n.prev == null) return true;
            else return false;
        }

        public bool IsLast(Node n)
        {
            if (n.next == null) return true;
            else return false;
        }

        public bool IsEmpty()
        {
            if (Size() == 0) return true;
            else return false;
        }

        public int Size()
        {
            return lista.Size();
        }
    }
}
