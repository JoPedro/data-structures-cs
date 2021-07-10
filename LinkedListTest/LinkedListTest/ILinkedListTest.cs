using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    interface ILinkedListTest
    {
        public void InsertAt();
        public void Append();
        public void AddBeginning();
        public Node Delete();
        public Node DeleteBeginning();
        public Node Get();
    }
}
