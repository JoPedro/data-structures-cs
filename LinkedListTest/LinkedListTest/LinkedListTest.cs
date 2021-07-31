using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    class LinkedListTest : ILinkedListTest
    {
        public Node start;
        private int size;

        public LinkedListTest(object o)
        {
            start = new Node(o);
            size = 1;
        }

        public Node Get(int index)
        {
            Node n = start;
            for (int i = 0; i < index; ++i)
                n = n.next;
            return n;
        }

        public void InsertAt(int index, object o)
        {
            if (index > 0)
            {
                Node noAnterior = Get(index - 1);
                Node newNode = new Node(o);
                newNode.next = noAnterior.next;
                noAnterior.next = newNode;
                size++;
            }
            else AddBeginning(o);
        }

        public void Append(object o)
        {
            Node n = start;
            while (true)
            {
                if (n.next == null) break;
                else n = n.next;
            }              
            n.next = new Node(o);
            size++;
        }

        public void AddBeginning(object o)
        {
            Node n = new Node(o);
            n.next = start;
            start = n;
            size++;
        }

        public Node DeleteBeginning()
        {
            Node n = start;
            start = start.next;
            size--;
            return n;           
        }

        public Node DeleteAt(int index)
        {
            Node n = Get(index - 1);
            Node n_aux = n.next;

            if (index == size - 1) Pop();
            else if (index > 0)
            {
                n.next = n.next.next;
                size--;               
            }
            else DeleteBeginning();           
            
            return n_aux;
        }

        public Node Pop()
        {
            Node n = start;
            while (true)
            {
                if (n.next == null) break;
                else n = n.next;
            }
            Node n_aux = n;
            DeleteAt(size-- - 1);
            return n_aux;
        }

        public int Size()
        {
            return size;
        }

        // Método para testes apenas
        public void PrintList()
        {
            Node n = start;
            while (true)
            {
                if (n.next == null)
                {
                    Console.Write(n.data.ToString(), ".");
                    break;
                }
                else
                {
                    Console.Write(n.data.ToString() + ", ");
                    n = n.next;
                }
            }
        }
    }
}
