using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDataStruct
{
    public class PilhaArray : PilhaRubroNegra
    {
        private object[] stackRN;
        private int size;
        private int topoRubro;
        private int topoNegro;
        private int capacity;

        public PilhaArray()
        {
            capacity = 32;
            stackRN = new object[capacity];
            topoRubro = 0;
            topoNegro = 0;
            size = 0;
        }

        public void PushRubro(object obj)
        {
            try
            {
                stackRN[++topoRubro] = obj;
            }
            catch(IndexOutOfRangeException)
            {
                DoubleCap(stackRN);
                stackRN[++topoRubro] = obj;
            }
        }

        public object PopRubro()
        {
            try
            {
                return stackRN[topoRubro--];
            }
            catch(EPilhaVazia)
            {

            }
        }

        private void DoubleCap(object[] arr)
        {

        }

        public int GetSizeRubro()
        {
            return topoRubro + 1;
        }
    }
}
