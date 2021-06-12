using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDataStruct
{
    public class PilhaRNArray : PilhaRubroNegra
    {
        private object[] stackRN;
        private int topoRubro;
        private int topoNegra;
        private int capacity;

        public PilhaRNArray()
        {
            capacity = 32;
            stackRN = new object[capacity];
            topoRubro = -1;
            topoNegra = -1;
        }

        public int Size()
        {
            return (topoRubro + 1) + (capacity - topoNegra);
        }

        public object TopRubro()
        {
            try { return stackRN[topoRubro]; }
            catch(EPilhaVazia) { throw new EPilhaVazia("A Pilha está vazia."); }
        }

        public object TopNegra()
        {
            try { return stackRN[topoNegra]; }
            catch (EPilhaVazia) { throw new EPilhaVazia("A Pilha está vazia."); }
        }

        public void PushRubro(object o)
        {
            if (capacity >= Size() + 1) { stackRN[++topoRubro] = o; }
            else
            {
                Array.Resize(ref stackRN, capacity * 2);
                int j = (capacity * 2) - 1;
                for (int i = capacity - 1; i >= topoNegra; --i)
                    stackRN[j--] = stackRN[i];
                capacity *= 2;
                topoNegra = j + 1;
            }
        }

        public void PushNegra(object o)
        {
            if (capacity >= Size() + 1) { stackRN[--topoNegra] = o; }
            else
            {
                Array.Resize(ref stackRN, capacity * 2);
                int j = (capacity * 2) - 1;
                for (int i = capacity - 1; i >= topoNegra; --i)
                    stackRN[j--] = stackRN[i];
                capacity *= 2;
                topoNegra = j + 1;
            }
        }

        public object PopRubro()
        {
            try { return stackRN[topoRubro--]; }
            catch (EPilhaVazia) { throw new EPilhaVazia("A Pilha está vazia."); }
        }

        public object PopNegra()
        {
            try { return stackRN[topoNegra++]; }
            catch (EPilhaVazia) { throw new EPilhaVazia("A Pilha está vazia."); }
        }

        public bool IsEmptyRubro()
        {
            if (topoRubro == -1) return true;
            else return false;
        }

        public bool IsEmptyNegra()
        {
            if (topoNegra == -1) return true;
            else return false;
        }
    }
}
