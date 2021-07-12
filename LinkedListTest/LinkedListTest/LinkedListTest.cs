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

        public LinkedListTest(object o)
        {
            start = new Node(o);
        }

        public Node Get(int index)
        {
            Node n = start;
            for (int i = 0; i < index; ++i)
            {
                n = n.next;
            }
            return n;
        }

        public void InsertAt(int index, object o)
        {
            if (index > 0)
            {
                Node n = Get(index - 1);
                n.next = new Node(o);
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
        }

        public void AddBeginning(object o)
        {
            Node n = new Node(o);
            n.next = start;
            start = n;
        }

        public Node DeleteBeginning()
        {
            Node n = start;
            start = start.next;
            return n;
        }

        public Node DeleteAt(int index)
        {
            if (index > 0)
            {
                Node n = Get(index - 1);
                Node n_aux = n.next;
                n.next = n.next.next;
                return n_aux;
            }
            else return DeleteBeginning();
        }

        public Node Pop()
        {
            Node n = start;
            int i = 0;
            while (true)
            {
                if (n.next == null) break;
                else
                {
                    n = n.next;
                    ++i;
                }
            }
            Node n_aux = n;
            DeleteAt(i);
            return n_aux;
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
