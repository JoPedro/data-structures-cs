using System;
using System.Collections;

namespace ArvoreGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testes usando a classe de Testes
            TesteArvore tree = new TesteArvore();

            // Antes do Swap
            Console.WriteLine("Printando a Árvore antes de trocar o valor dos elementos do Nó raiz e de seu primeiro filho");
            tree.PrintTree(tree.Raiz());

            Console.WriteLine();

            // Depois do Swap
            Console.WriteLine("Printando a Árvore depois de trocar o valor dos elementos do Nó raiz e de seu primeiro filho");
            tree.TesteSwapElem();
            tree.PrintTree(tree.Raiz());

            Console.WriteLine();

            // Altura da Árvore
            Console.WriteLine("Altura: " + tree.TesteAltura());

            Console.WriteLine();
            Console.Write("Elementos dos nós da Árvore: ");

            // Elementos dos nós da Árvore
            IEnumerator elementos = tree.TesteElements();
            while (elementos.MoveNext())
            {
                Console.Write(elementos.Current.ToString() + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Nós da Árvore: ");

            // Nós da Árvore
            IEnumerator nos = tree.TesteNos();
            while (nos.MoveNext())
            {
                Console.Write(nos.Current.ToString() + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();

            // Tamanho da Árvore
            Console.Write("Tamanho da Árvore: " + tree.TesteTamanho());

            Console.WriteLine();
            Console.WriteLine();

            // Alterando o elemento de um nó
            Console.WriteLine("Trocando o valor do elemento de um nó");
            Console.Write("Valor original: " + tree.Raiz().Element() + ", ");

            tree.TesteReplace(tree.Raiz(), "Raiz");

            Console.Write("Valor atualizado: " + tree.Raiz().Element() + "");
            Console.WriteLine();
            Console.WriteLine();
            tree.PrintTree(tree.Raiz());
        }
    }
}
