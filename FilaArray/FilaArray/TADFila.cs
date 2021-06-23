using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaArray
{
    class TADFila : IFila
    {
        // Implementação de TAD (Tipo Abstrato de Dado) Fila com Array

        private object[] queueArray;
        private int capacity;
        private int inicio;
        private int fim;
        
        public TADFila(int inicio)
        {
            this.inicio = inicio;
            fim = inicio; 
            capacity = 32;
            queueArray = new object[capacity];
        }

        public void Queue(object o)
        {
            if (Size() >= capacity - 1)
            {
                Array.Resize(ref queueArray, capacity << 1);
                fim = capacity;
                capacity <<= 1;               
            }
            else
            {
                queueArray[fim] = o;
                fim = (fim + 1) % capacity;
            }
        }

        public object Dequeue()
        {
            if (!IsEmpty())
            {
                object o = queueArray[inicio];
                inicio = (inicio + 1) % capacity;
                return o;
            }
            else throw new EFilaVazia("A fila está vazia.");
        }

        public object First()
        {
            if (!IsEmpty()) return queueArray[inicio];
            else throw new EFilaVazia("A Fila está vazia.");
        }

        public bool IsEmpty()
        {
            if (inicio == fim) return true;
            else return false;
        }

        public int Size()
        {
            return (capacity - inicio + fim) % capacity;
        }

        public object[] TestFila()
        {
            return queueArray;
        }
    }
}
