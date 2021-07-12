using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    interface ILinkedListTest
    {
        public void InsertAt(int index, object o);
        public void Append(object o);
        public void AddBeginning(object o);
        public Node DeleteAt(int index);
        public Node Pop();
        public Node DeleteBeginning();
        public Node Get(int index);
    }
}
