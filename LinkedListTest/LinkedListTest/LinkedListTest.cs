using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    class LinkedListTest : ILinkedListTest
    {
        private Node start;

        public LinkedListTest(object o)
        {
            start = new Node(o);
        }

        public void InsertAt(object o)
        {

        }

        public void Append()
        {

        }
    }
}
