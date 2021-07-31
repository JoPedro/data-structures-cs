using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADLista
{
    interface ITADLista
    {
        public void ReplaceElement(Node n, object o);
        public void SwapElements(Node n, Node m);
        public void InsertBefore(Node n, object o);
        public void InsertAfter(Node n, object o);
        public void InsertFirst(object o);
        public void InsertLast(object o);
        public Node Remove(Node n);
        public Node Before(Node n);
        public Node After(Node n);
        public Node First();
        public Node Last();
        public bool IsFirst(Node n);
        public bool IsLast(Node n);
        public bool IsEmpty();
        public int Size();
    }
}
