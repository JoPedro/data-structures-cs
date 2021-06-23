using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaArray
{
    class TADFila : IFila
    {
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

        public object First()
        {
            return queueArray[inicio];
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
