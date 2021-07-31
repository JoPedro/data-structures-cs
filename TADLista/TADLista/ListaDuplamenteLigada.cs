using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADLista
{
    class ListaDuplamenteLigada : IListaDuplamenteLigada
    {
        private Node head;
        private Node tail;
        private int tamanho;

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
                Node noAnterior = Get(index - 1);
                Node noProximo = Get(index + 1);

                Node n = new Node(o);
                noAnterior.next = n;
                noProximo.prev = n;

                n.prev = noAnterior;
                n.next = noProximo;

                tamanho++;
            }
            else AddBeginning(o);
        }

        public void AddBeginning(object o)
        {
            Node n = head;
            Node newNode = new Node(o);
            n.prev = newNode;
            newNode.next = n;
            head = newNode;
            tamanho++;
        }

        public void Append(object o)
        {
            Node n = tail;
            Node newNode = new Node(o);
            n.next = newNode;
            newNode.prev = n;
            tail = newNode;
            tamanho++;
        }

        public Node DeleteAt(int index)
        {
            Node noAnterior = Get(index - 1);
            Node n_aux = noAnterior.next;

            if (index == tamanho - 1) Pop();
            else if (index > 0)
            {
                noAnterior.next = noAnterior.next.next;
                tamanho--;
            }
            else DeleteBeginning();

            return n_aux;
        }

        public Node Pop()
        {
            Node n = tail;
            Node n_aux = n;
            tail = n.prev;
            tamanho--;
            return n_aux;
        }

        public Node DeleteBeginning()
        {
            Node n = head;
            head = head.next;
            tamanho--;
            return n;
        }

        public int Size()
        {
            return tamanho;
        }
    }
}
