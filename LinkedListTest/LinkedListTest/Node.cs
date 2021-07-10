using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    class Node
    {
        public object data;
        public Node next;

        public Node(object o)
        {
            data = o;
            next = null;
        }
    }
}
