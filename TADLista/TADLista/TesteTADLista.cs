using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADLista
{
    class TesteTADLista
    {
        private TADLista lista;

        public TesteTADLista()
        {
            lista = new TADLista();
        }

        public void Teste()
        {
            TADLista lista = new TADLista();

            lista.InsertFirst(0);
            lista.InsertLast(1);
            lista.PrintList();

            lista.InsertBefore(lista.Last(), 5);
            lista.PrintList();

            // Inserindo antes do início da lista
            lista.InsertAfter(lista.Last(), "After");
            lista.PrintList();

            // Inserindo após o final da lista
            lista.InsertBefore(lista.First(), "Begin");
            lista.PrintList();

            lista.InsertFirst("First");
            lista.PrintList();

            lista.InsertLast("Last");
            lista.PrintList();

            lista.ReplaceElement(lista.After(lista.First()), "Second element replaced");
            lista.PrintList();

            lista.SwapElements(lista.After(lista.After(lista.After(lista.First()))), lista.First().next);
            lista.PrintList();

            lista.Remove(lista.After(lista.After(lista.After(lista.First()))));
            lista.PrintList();
        }
    }
}
