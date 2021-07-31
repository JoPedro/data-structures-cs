using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADLista
{
    class Node
    {
        private object data;
        public object Data { get; set; }

        public Node next;
        public Node prev;

        public Node()
        {
            next = null;
            prev = null;
        }

        public Node(object o)
        {
            data = o;
            next = null;
            prev = null;
        }
    }
}
