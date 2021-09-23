using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADHashTable
{
    class TesteHashTable
    {
        private TADHashTable hashtable;

        /*
            Por motivos de eficiência e facilitação dos testes, os métodos de tratamento 
            de colisão serão ambos considerados no desenvolvimento dos métodos, assim, cada 
            método há duas versões, uma considerando o tratamento por Linear
            Probing, outra considerando por Hashing Duplo.
        */

        // Métodos com Linear Probing
        public void TesteLinearProbing()
        {
            hashtable = new TADHashTable();

            // Testando Inserir com Linear Probing
            hashtable.InsertElementLinearProbing(18, "Elemento 1");
            hashtable.InsertElementLinearProbing(41, "Elemento 2");
            hashtable.InsertElementLinearProbing(22, "Elemento 3");
            hashtable.InsertElementLinearProbing(44, "Elemento 4");
            hashtable.InsertElementLinearProbing(59, "Elemento 5");
            hashtable.InsertElementLinearProbing(32, "Elemento 6");

            PrintTable(hashtable);

            // Testando fator de carga e duplicamento
            hashtable.InsertElementLinearProbing(31, "Elemento 7");
            hashtable.InsertElementLinearProbing(73, "Elemento 8");

            PrintTable(hashtable);
            Console.WriteLine();

            // Testando Find com Key
            Console.WriteLine(hashtable.FindElementLinearProbing(31));

            // Testando remover com key
            Item itemRemovido = (Item)hashtable.RemoveElementLinearProbing(31);
            Console.WriteLine(itemRemovido.Key + ", " + itemRemovido.Element + " removido");

            PrintTable(hashtable);
        }

        // Métodos com Linear Probing
        public void TesteHashingDuplo()
        {
            hashtable = new TADHashTable();

            // Testando Inserir com Linear Probing
            hashtable.InsertElementHashingDuplo(18, "Elemento 1");
            hashtable.InsertElementHashingDuplo(41, "Elemento 2");
            hashtable.InsertElementHashingDuplo(22, "Elemento 3");
            hashtable.InsertElementHashingDuplo(44, "Elemento 4");
            hashtable.InsertElementHashingDuplo(59, "Elemento 5");
            hashtable.InsertElementHashingDuplo(32, "Elemento 6");

            PrintTable(hashtable);

            // Testando fator de carga e duplicamento
            hashtable.InsertElementHashingDuplo(31, "Elemento 7");
            hashtable.InsertElementHashingDuplo(73, "Elemento 8");

            PrintTable(hashtable);
            Console.WriteLine();
            
            // Testando Find com Key
            Console.WriteLine(hashtable.FindElementHashingDuplo(73));

            // Testando remover com key
            Item itemRemovido = (Item)hashtable.RemoveElementHashingDuplo(73);
            Console.WriteLine(itemRemovido.Key + ", " + itemRemovido.Element + " removido");

            PrintTable(hashtable);
        }

        // Printando o array diretamente mostrando apenas as chaves, para fins de teste
        public void PrintTable(TADHashTable hashtable)
        {
            Console.Write("{ ");
            for (int i = 0; i < hashtable.Capacity(); ++i)
            {
                if (hashtable.GetTable()[i] != null && hashtable.GetTable()[i].Available == false)
                    Console.Write(hashtable.GetTable()[i].Key);
                else
                    Console.Write("∅");

                if (i < hashtable.Capacity() - 1)
                    Console.Write(", ");
            }
            Console.Write(" }\n");
        }
    }
}
