using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADFilaPrioridadeHeapArray
{
    class FilaPrioridadeHeapArray : IFilaPrioridade
    {
        private Item[] arr;
        private int tamanho;
        private int capacity;

        public FilaPrioridadeHeapArray()
        {
            arr = new Item[32];
            tamanho = 0;
            capacity = 32;
        }

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
                if (TADComparadorNumero.Compare(arr[i], arr[2 * i]) == 1 || TADComparadorNumero.Compare(arr[i], arr[2 * i]) == 0)
                {
                    Swap(arr[i], arr[2 * i]);
                    i *= 2;
                }
                else if (2 * i + 1 <= tamanho)
                {
                    if (TADComparadorNumero.Compare(arr[i], arr[2 * i + 1]) == 1 || TADComparadorNumero.Compare(arr[i], arr[2 * i + 1]) == 0)
                    {
                        Swap(arr[i], arr[2 * i + 1]);
                        i = i * 2 + 1;
                    }
                }
                else break;
            }           
        }

        public void Inserir(object k, object o)
        {
            int key = (int)k;
            Item elem = new Item(key, o);
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
            object aux = e.Value();
            e.SetValue(f.Value());
            f.SetValue(aux);

            int aux1 = (int)e.Key();
            e.SetKey((int)f.Key());
            f.SetKey(aux1);
        }

        public Item RemoveMin()
        {
            Swap(arr[1], arr[tamanho]);
            Item itemRemovido = arr[tamanho];
            arr[tamanho--] = null;
            DownHeap();
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
            if (tamanho == 0) return true;
            else return false;
        }

        public void Teste()
        {
            while(Size() > 0)
            {
                Console.Write(RemoveMin().Value() + ", ");
            }
        }
    }
}
