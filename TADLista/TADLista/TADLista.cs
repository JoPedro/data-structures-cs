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
            if (n.prev != null)
            {
                Node noAnterior = n.prev;
                Node newNode = new Node(o);
                n.prev = newNode;
                noAnterior.next = newNode;

                newNode.prev = noAnterior;
                newNode.next = n;

                lista.tamanho++;
            }
            else
            {
                Node newNode = new Node(o);
                newNode.next = n;
                newNode.prev = null;
                n.prev = newNode;
                lista.head = newNode;
                lista.tamanho++;
            }
        }

        public void InsertAfter(Node n, object o)
        {
            if (n.next != null)
            {
                Node noProximo = n.next;
                Node newNode = new Node(o);
                n.next = newNode;
                noProximo.prev = newNode;

                newNode.next = noProximo;
                newNode.prev = n;
                lista.tamanho++;
            }
            else
            {
                Node newNode = new Node(o);
                newNode.prev = n;
                newNode.next = null;
                n.next = newNode;
                lista.tail = newNode;
                lista.tamanho++;
            }
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
            if (IsEmpty()) throw new EListaVazia("A Lista está vazia.");
            if (n.next != null && n.prev != null)
            {
                n.prev.next = n.next;
                n.next.prev = n.prev;
                lista.tamanho--;
                return n;
            }
            else if (n.next == null)
            {
                n.prev.next = null;
                lista.tail = n.prev;
                lista.tamanho--;
                return n;
            }
            else
            {
                n.next.prev = null;
                lista.head = n.next;
                lista.tamanho--;
                return n;
            }
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

        public void PrintList()
        {
            lista.PrintList();
            Console.WriteLine();

            Console.WriteLine("Tamanho: " + lista.Size());
            Console.WriteLine("Head: " + First().Data);
            Console.WriteLine("Tail: " + Last().Data + "\n");
        }
    }
}
