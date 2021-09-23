using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADHashTable
{
    class TADHashTable
    {
        private Item[] table;
        private int tamanho;
        private int capacity;

        public TADHashTable()
        {
            table = new Item[32];
            capacity = 32;
            tamanho = 0;
        }

        private int HashCode(object key)
        {
            return (int)key % capacity;
        }

        // Encontrar elemento utilizando Hashing Duplo
        public object FindElementHashingDuplo(object key)
        {

        }

        // Encontrar elemento utilizando Linear Probing
        public object FindElementLinearProbing(object key)
        {
            int h = HashCode(key);
            int cont = 0;
            while(cont != capacity)
            {
                Item item = table[h];
                if (item == null) 
                    return new ENoSuchKey("Chave não encontrada na tabela");
                else if (item.Key == key) 
                    return item.Element;
                else
                {
                    h = (h + 1) % capacity;
                    cont++;
                }
            }
            return new ENoSuchKey("Chave não encontrada na tabela");
        }

        // Inserir elemento, caso colisão utilizar Linear Probing (verificar alfa, duplicar se necessário)
        public void InsertElementLinearProbing(object key, object element, Item[] table)
        {
            int h = HashCode(key);
            int cont = 0;
            while (cont != capacity)
            {
                if (table[h] == null || table[h].Available == true)
                {
                    table[h] = new Item(key, element);
                    tamanho++;
                    break;
                }
                else
                {
                    h = (h + 1) % capacity;
                    cont++;
                }
            }
            if (tamanho > capacity / 2)
            {
                RehashLinearProbing();
            }
        }

        // Inserir elemento, caso colisão utilizar Hashing Duplo (verificar alfa, duplicar se necessário)
        public void InsertElementHashingDuplo(object key, object element)
        {

        }

        // Efetuar Rehash utilizando Linear Probing
        public void RehashLinearProbing()
        {
            IEnumerator keys = Keys();
            while (keys.MoveNext())
            {

            }
        }

        // Efetuar Rehash utilizando Hashing Duplo
        public void RehashHashingDuplo()
        {
            Item[] newTable = new Item[capacity << 1];
            capacity <<= 1;
            tamanho = 0;
            foreach (Item i in table)
            {
                if (i != null && i.Available == false)
                    InsertElementLinearProbing(i.Key, i.Element, newTable);
            }

            table = newTable;
        }

        // Remover e retornar elemento, utilizando Linear Probing para encontrá-lo
        public object RemoveElementLinearProbing(object key)
        {
            int h = HashCode(key);
            int cont = 0;
            while (cont != capacity)
            {
                Item item = table[h];
                if (item == null)
                    return new ENoSuchKey("Chave não encontrada na tabela");
                else if (item.Key == key)
                {
                    item.Available = true;
                    tamanho--;
                    return item;
                }
                else
                {
                    h = (h + 1) % capacity;
                    cont++;
                }
            }
            return new ENoSuchKey("Chave não encontrada na tabela");
        }

        // Remover e retornar elemento, utilizando Hashing duplo para encontrá-lo
        public object RemoveElementHashingDuplo(object key)
        {

        }

        // Métodos adicionais
        public int Size()
        {
            return tamanho;
        }

        public bool IsEmpty()
        {
            if (tamanho == 0) return true;
            else return false;
        }

        public IEnumerator Keys()
        {
            ArrayList keys = new ArrayList();
            foreach (Item i in table) {
                if (i != null && i.Available == false) 
                    keys.Add(i.Key);
            }
            return keys.GetEnumerator();
        }

        public IEnumerator Elements()
        {
            ArrayList elements = new ArrayList();
            foreach (Item i in table)
            {
                if (i != null && i.Available == false)
                    elements.Add(i.Element);
            }
            return elements.GetEnumerator();
        }
    }
}
