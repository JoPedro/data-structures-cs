using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DequeArrayList
{
    class TADDeque : IDeque
    {
        private readonly ArrayList dequeList;
        private int inicio;
        private int fim;

        public TADDeque(int inicio)
        {
            dequeList = new ArrayList(32);
            this.inicio = inicio;
            fim = inicio;           
        }

        public void InserirInicio(object o)
        {
            dequeList.Insert(inicio, o);
            inicio = (inicio - 1) % dequeList.Capacity;
        }

        public void InserirFim(object o)
        {
            dequeList.Insert(fim, o);
            fim = (fim + 1) % dequeList.Capacity;
        }

        public object RemoverInicio()
        {
            if (!IsEmpty())
            {
                object o = dequeList[inicio];
                inicio = (inicio + 1) % dequeList.Capacity;
                return o;
            }
            else throw new DequeVazioException("O Deque está vazio.");
        }

        public object RemoverFim()
        {
            if (!IsEmpty())
            {
                object o = dequeList[fim];
                fim = (fim - 1) % dequeList.Capacity;
                return o;
            }
            else throw new DequeVazioException("O Deque está vazio.");
        }

        public object First()
        {
            if (!IsEmpty()) return dequeList[(inicio + 1) % dequeList.Capacity];
            else throw new DequeVazioException("O Deque está vazio.");
        }

        public object Last()
        {
            if (!IsEmpty()) return dequeList[(fim - 1) % dequeList.Capacity];
            else throw new DequeVazioException("O Deque está vazio.");
        }

        public int Size()
        {
            return (dequeList.Capacity - (inicio + 1) + fim) % dequeList.Capacity;
        }

        public bool IsEmpty()
        {
            if (inicio == fim) return true;
            else return false;
        }

        public void Mostrar()
        {
            foreach (object elem in dequeList)
            {
                if (elem != null) Console.WriteLine(elem.ToString());
                Console.Write(", ");
            }
            Console.WriteLine("\n");
        }
    }
}
