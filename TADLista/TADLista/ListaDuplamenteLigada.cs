using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADLista
{
    class ListaDuplamenteLigada : IListaDuplamenteLigada
    {
        public Node head;
        public Node tail;
        internal int tamanho;

        public ListaDuplamenteLigada()
        {
            head = new Node();
            tail = new Node();
            head.next = tail;
            tail.prev = head;
            tamanho = 0;
        }

        public ListaDuplamenteLigada(object o1, object o2)
        {
            head = new Node(o1);
            tail = new Node(o2);
            head.next = tail;
            tail.prev = head;
            tamanho = 2;
        }

        public Node Get(int index)
        {
            if (index >= tamanho/2)
            {
                Node n = tail;
                for (int i = tamanho-1; i > index; --i)
                    n = n.prev;
                return n;
            }
            else
            {
                Node n = head;
                for (int i = 0; i < index; ++i)
                    n = n.next;
                return n;
            }
        }

        public void InsertAt(int index, object o)
        {
            if (index > 0)
            {
                if (index == tamanho) Append(o);
                else
                {
                    Node noAnterior = Get(index - 1);
                    Node noProximo = Get(index);

                    Node n = new Node(o);
                    noAnterior.next = n;
                    noProximo.prev = n;

                    n.prev = noAnterior;
                    n.next = noProximo;

                    tamanho++;
                }
            }
            else AddBeginning(o);
        }

        public void AddBeginning(object o)
        {
            if (head.Data == null)
            {
                head.Data = o;
                tamanho++;
            }
            else
            {
                Node n = head;
                Node newNode = new Node(o);
                n.prev = newNode;
                newNode.next = n;
                head = newNode;
                tamanho++;
            }
        }

        public void Append(object o)
        {
            if (!IsEmpty())
            {
                if (tamanho == 1 && head.Data != null)
                {
                    tail.Data = o;
                    tamanho++;
                }
                else
                {
                    Node n = tail;
                    Node newNode = new Node(o);
                    n.next = newNode;
                    newNode.prev = n;
                    tail = newNode;
                    tamanho++;
                }
                
            }
            else
            {
                head.Data = o;
                tamanho++;
            }                        
        }

        public Node DeleteAt(int index)
        {
            if (IsEmpty()) throw new EListaVazia("A Lista está vazia.");

            Node n = Get(index);
            Node n_aux = n;

            if (index == tamanho - 1) Pop();
            else if (index > 0)
            {
                n.prev.next = n.next;
                n.next.prev = n.prev;
                tamanho--;
            }
            else DeleteBeginning();

            return n_aux;
        }

        public Node Pop()
        {
            if (IsEmpty()) throw new EListaVazia("A Lista está vazia.");
            Node n = tail;
            tail = n.prev;
            tail.next = null;
            tamanho--;
            return n;
        }

        public Node DeleteBeginning()
        {
            if (IsEmpty()) throw new EListaVazia("A Lista está vazia.");
            Node n = head;
            head = head.next;
            head.prev = null;
            tamanho--;
            return n;
        }

        public int Size()
        {
            return tamanho;
        }

        // Método para testes apenas
        public void PrintList()
        {
            Node n = head;
            while (true)
            {
                if (n.next == null)
                {
                    Console.Write(n.Data.ToString(), ".");
                    break;
                }
                else
                {
                    Console.Write(n.Data.ToString() + ", ");
                    n = n.next;
                }
            }
        }

        public bool IsEmpty()
        {
            if (tamanho == 0) return true;
            else return false;
        }
    }
}
