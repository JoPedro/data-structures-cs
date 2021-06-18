using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaRBVectorCS
{
    class TADPilha : IPilhaVector
    {
        private ArrayList stackVector;
        private int topo;
        private int capacity;

        public TADPilha()
        {
            capacity = 32;
            stackVector = new ArrayList(capacity);
            topo = -1;
        }

        public int Size()
        {
            return topo + 1;
        }

        public void Push(object o)
        {
            stackVector.Add(o);
            ++topo;
        }

        public bool IsEmpty()
        {
            if (topo == -1) return true;
            else return false;
        }

        public object Pop()
        {
            if (!IsEmpty()) {
                object last = stackVector[topo];
                stackVector.Remove(topo);
                return last; 
            }
            else { throw new PilhaVaziaException("A Pilha está vazia."); }
        }

        public object Top()
        {
            if (!IsEmpty()) { return stackVector[topo]; }
            else { throw new PilhaVaziaException("A Pilha está vazia."); }
        }

        public ArrayList GetVector()
        {
            return stackVector;
        }
    }
}
