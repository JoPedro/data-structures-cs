using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDataStruct
{
    public class PilhaRBArray : IPilhaRedBlack
    {
        private object[] stackRN;
        private int topoRed;
        private int topoBlack;
        private int capacity;

        public PilhaRBArray()
        {
            capacity = 32;
            stackRN = new object[capacity];
            topoRed = -1;
            topoBlack = capacity;
        }

        public int Size()
        {
            if (IsEmptyRed() && !IsEmptyBlack())
                return capacity - Math.Abs(topoBlack);
            else if (!IsEmptyRed() && IsEmptyBlack())
                return topoRed + 1;
            else if (!IsEmptyRed() && !IsEmptyBlack())
                return (topoRed + 1) + (capacity - Math.Abs(topoBlack));
            else
                return 0;
        }

        public object TopRed()
        {
            if (!IsEmptyRed()) { return stackRN[topoRed]; }
            else { throw new EPilhaVazia("A Pilha está vazia."); }
        }

        public object TopBlack()
        {
            if (!IsEmptyBlack()) { return stackRN[topoBlack]; }
            else { throw new EPilhaVazia("A Pilha está vazia."); }
        }

        public void PushRed(object o)
        {
            if (Size() >= capacity)
            {
                Array.Resize(ref stackRN, capacity << 1);
                int j = (capacity << 1) - 1;
                for (int i = capacity - 1; i >= topoBlack; --i)
                    stackRN[j--] = stackRN[i];
                capacity <<= 1;
                topoBlack = j + 1;
            }
            else stackRN[++topoRed] = o;
        }

        public void PushBlack(object o)
        {
            if (Size() >= capacity)
            {
                Array.Resize(ref stackRN, capacity << 1);
                int j = (capacity << 1) - 1;
                for (int i = capacity - 1; i >= topoBlack; --i)
                    stackRN[j--] = stackRN[i];
                capacity <<= 1;
                topoBlack = j + 1;
            }
            else stackRN[--topoBlack] = o;
        }

        public object PopRed()
        {
            if (!IsEmptyRed()) { return stackRN[topoRed--]; }
            else { throw new EPilhaVazia("A Pilha está vazia."); }
        }

        public object PopBlack()
        {
            if (!IsEmptyBlack()) { return stackRN[topoBlack--]; }
            else { throw new EPilhaVazia("A Pilha está vazia."); }
        }

        public bool IsEmptyRed()
        {
            if (topoRed == -1) return true;
            else return false;
        }

        public bool IsEmptyBlack()
        {
            if (topoBlack == capacity) return true;
            else return false;
        }

        public object[] TestArray()
        {
            return stackRN;
        }
    }
}
