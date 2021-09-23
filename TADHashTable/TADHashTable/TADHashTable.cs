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
            table = new Item[13];
            capacity = 13;
            tamanho = 0;
        }

        public Item[] GetTable()
        {
            return table;
        }

        private int HashCode(object key)
        {
            return (int)key % capacity;
        }

        /*
            Por motivos de eficiência e facilitação dos testes, os métodos de tratamento 
            de colisão serão ambos considerados no desenvolvimento dos métodos, assim, cada 
            método há duas versões, uma considerando o tratamento por Linear
            Probing, outra considerando por Hashing Duplo.
        */

        // Encontrar elemento utilizando Linear Probing
        public object FindElementLinearProbing(object key)
        {
            int h = HashCode(key);
            int cont = 0;
            while (cont < capacity)
            {
                Item item = table[h];
                if (item == null)
                    return new ENoSuchKey("Chave não encontrada na tabela");
                else if ((int)item.Key == (int)key)
                    return item.Element;
                else
                {
                    h = (h + 1) % capacity;
                    cont++;
                }
            }
            return new ENoSuchKey("Chave não encontrada na tabela");
        }

        // Encontrar elemento utilizando Hashing Duplo
        public object FindElementHashingDuplo(object key)
        {
            int h = HashCode(key);
            int cont = 0;
            while (cont < capacity)
            {
                Item item = table[h];
                if (item == null)
                    return new ENoSuchKey("Chave não encontrada na tabela");
                else if ((int)item.Key == (int)key)
                    return item.Element;
                else
                {
                    h = (h + (7 - (int)key % 7)) % capacity;
                    cont++;
                }
            }
            return new ENoSuchKey("Chave não encontrada na tabela");
        }

        // Inserir elemento, caso colisão utilizar Linear Probing (verificar alfa, duplicar se necessário)
        public void InsertElementLinearProbing(object key, object element)
        {
            int h = HashCode(key);
            int cont = 0;
            while (cont < capacity)
            {
                if (table[h] == null || table[h].Available == true)
                {
                    table[h] = new Item(key, element);
                    tamanho++;
                    if (tamanho > capacity / 2)
                        RehashLinearProbing();
                    break;
                }
                else
                {
                    h = (h + 1) % capacity;
                    cont++;
                }
            }
        }

        // Inserir elemento, caso colisão utilizar Hashing Duplo (verificar alfa, duplicar se necessário)
        public void InsertElementHashingDuplo(object key, object element)
        {
            int h = HashCode(key);
            int cont = 0;
            while (cont < capacity)
            {
                if (table[h] == null || table[h].Available == true)
                {
                    table[h] = new Item(key, element);
                    tamanho++;
                    if (tamanho > capacity / 2)
                        RehashHashingDuplo();
                    break;
                }
                else
                {
                    h = (h + (7 - (int)key % 7)) % capacity;
                    cont++;
                }
            }
        }

        // Efetuar Rehash utilizando Linear Probing
        public void RehashLinearProbing()
        {
            ArrayList itens = new ArrayList();

            foreach (Item i in table)
            {
                if (i != null && i.Available == false)
                {
                    itens.Add(i);
                    i.Available = true;
                }
            }

            capacity <<= 1;
            tamanho = 0;

            Array.Resize(ref table, capacity);

            foreach (Item i in itens)
                InsertElementLinearProbing(i.Key, i.Element);
        }

        // Efetuar Rehash utilizando Hashing Duplo
        public void RehashHashingDuplo()
        {
            ArrayList itens = new ArrayList();

            foreach (Item i in table)
            {
                if (i != null && i.Available == false)
                {
                    itens.Add(i);
                    i.Available = true;
                }
            }

            capacity <<= 1;
            tamanho = 0;

            Array.Resize(ref table, capacity);

            foreach (Item i in itens)
                InsertElementHashingDuplo(i.Key, i.Element);
        }

        // Remover e retornar elemento, utilizando Linear Probing para encontrá-lo
        public object RemoveElementLinearProbing(object key)
        {
            int h = HashCode(key);
            int cont = 0;
            while (cont < capacity)
            {
                Item item = table[h];
                if (item == null)
                    return new ENoSuchKey("Chave não encontrada na tabela");
                else if ((int)item.Key == (int)key)
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
            int h = HashCode(key);
            int cont = 0;
            while (cont < capacity)
            {
                Item item = table[h];
                if (item == null)
                    return new ENoSuchKey("Chave não encontrada na tabela");
                else if ((int)item.Key == (int)key)
                {
                    item.Available = true;
                    tamanho--;
                    return item;
                }
                else
                {
                    h = (h + (7 - (int)key % 7)) % capacity;
                    cont++;
                }
            }
            return new ENoSuchKey("Chave não encontrada na tabela");
        }

        // Métodos adicionais
        public int Size()
        {
            return tamanho;
        }

        public int Capacity()
        {
            return capacity;
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
