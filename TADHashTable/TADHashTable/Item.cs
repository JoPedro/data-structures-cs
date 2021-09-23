using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADHashTable
{
    class Item
    {
        public object Key { get; set; }
        public object Element { get; set; }

        public bool Available { get; set; }

        public Item(object key, object element)
        {
            Key = key;
            Element = element;
            Available = false;
        }
    }
}
