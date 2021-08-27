using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADFilaPrioridadeHeapArray
{
    class FilaPrioridadeHeapArray
    {
        private Item[] arr;
        private int tamanho;
        private int capacity;

        public void UpHeap()
        {

        }

        public void DownHeap()
        {
            int i = 1;
            while (true)
            {
                if (2 * i > tamanho)
                    break;
                if (arr[i].Key >= arr[2 * i].Key)
                {
                    Swap(arr[i], arr[2 * i]);
                    i *= 2;
                }
                else if (arr[i].Key >= arr[2 * i + 1].Key)
                {
                    Swap(arr[i], arr[2 * i + 1]);
                    i = i * 2 + 1;
                }
                else break;
            }           
        }

        public void Inserir(Item elem)
        {
            if (tamanho + 1 < capacity)
                arr[tamanho++ + 1] = elem;
            else
            {
                Array.Resize(ref arr, capacity << 1);
                capacity <<= 1;
                arr[tamanho++ + 1] = elem;
            }
        }

        public void Swap(Item e, Item f)
        {
            object aux = e.Value;
            e.Value = f.Value;
            f.Value = aux;
        }

        public Item RemoveMin()
        {
            Item itemRemovido = arr[1];
            arr[1] = arr[tamanho];
            tamanho--;
            return itemRemovido;
        }

        public Item Min()
        {
            return arr[1];
        }

        public int Size()
        {
            return tamanho;
        }

        public bool IsEmpty()
        {

        }
    }
}
