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
            return (int)key % tamanho;
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
            while(cont != tamanho)
            {
                Item item = table[h];
                if (item == null) 
                    return new ENoSuchKey("Chave não encontrada na tabela");
                else if (item.Key == key) 
                    return item.Element;
                else
                {
                    h = (h + 1) % tamanho;
                    cont++;
                }
            }
            return new ENoSuchKey("Chave não encontrada na tabela");
        }

        // Inserir elemento, caso colisão utilizar Linear Probing (verificar alfa, duplicar se necessário)
        public void InsertElementLinearProbing(Item item)
        {
            
        }

        // Inserir elemento, caso colisão utilizar Hashing Duplo (verificar alfa, duplicar se necessário)
        public void InsertElementHashingDuplo(Item item)
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
            IEnumerator keys = Keys();
            while (keys.MoveNext())
            {

            }
        }

        // Remover e retornar elemento, utilizando Linear Probing para encontrá-lo
        public object RemoveElementLinearProbing(object key)
        {
            int h = HashCode(key);
            int cont = 0;
            while (cont != tamanho)
            {
                Item item = table[h];
                if (item == null)
                    return new ENoSuchKey("Chave não encontrada na tabela");
                else if (item.Key == key)
                {
                    item.Available = true;
                    return item;
                }
                else
                {
                    h = (h + 1) % tamanho;
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
