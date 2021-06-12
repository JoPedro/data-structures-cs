using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDataStruct
{
    interface PilhaRubroNegra
    {
        public int Size();
        public bool IsEmptyRubro();
        public bool IsEmptyNegra();
        public object TopRubro();
        public object TopNegra();
        public void PushRubro(object o);
        public void PushNegra(object o);
        public object PopRubro();
        public object PopNegra();
    }
}
