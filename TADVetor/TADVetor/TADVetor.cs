using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADVetor
{
    public class TADVetor : IVetor
    {
        private object[] arr;
        private int tamanho;
        private int capacity;

        public TADVetor()
        {
            capacity = 64;
            arr = new object[capacity];
            tamanho = 0;
        }

        public object ElemAtRank(int r)
        {
            if (IsEmpty()) throw new EVetorVazio("O Vetor está vazio.");
            if (r >= tamanho) throw new ERankInvalido("Colocação inválida para esta operação.");

            return arr[r];
        }

        public object ReplaceAtRank(int r, object o)
        {
            if (IsEmpty()) throw new EVetorVazio("O Vetor está vazio.");
            if (r >= tamanho) throw new ERankInvalido("Colocação inválida para esta operação.");

            object old = arr[r];
            arr[r] = o;
            return old;
        }

        public void InsertAtRank(int r, object o)
        {            
            if (r >= tamanho)
            {
                capacity <<= 1;
                Array.Resize(ref arr, capacity);               
            }

            for (int i = tamanho; i > r; --i)
                arr[i] = arr[i - 1];

            arr[r] = o;
            ++tamanho;
        }

        public object RemoveAtRank(int r)
        {
            if (IsEmpty()) throw new EVetorVazio("O Vetor está vazio.");
            if (r >= tamanho) throw new ERankInvalido("Colocação inválida para esta operação.");

            object removed = arr[r];

            for (int i = r; i < tamanho; ++i)
                arr[i] = arr[i + 1];

            --tamanho;
            return removed;
        }

        public bool IsEmpty()
        {
            if (tamanho > 0) return false;
            else return true;
        }

        public int Size()
        {
            return tamanho;
        }
    }
}
