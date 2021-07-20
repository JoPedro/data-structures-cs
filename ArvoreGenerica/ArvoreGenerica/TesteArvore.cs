using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreGenerica
{
    class TesteArvore
    {
        private ArvoreSimples tree;

        public TesteArvore()
        {
            tree = new ArvoreSimples('A');
            tree.AddChild(tree.Root(), 'B');
            tree.AddChild(tree.Root(), 'C');
            tree.AddChild(tree.Root(), 'D');
            tree.AddChild(tree.Root(), 'E');

            IEnumerator filhos = tree.Children(tree.Root());

            while (filhos.MoveNext())
            {
                char teste = 'F';
                No n = (No)filhos.Current;
                tree.AddChild(n, teste++);
                tree.AddChild(n, teste++);
            }
        }

        public No Raiz()
        {
            return tree.Root();
        }

        public void PrintTree(No n, int depth = 0)
        {
            Console.WriteLine(depth + " - " + n.Element());

            for (int i = 0; i < n.ChildrenNumber(); i++)
            {
                PrintTree((No)n.ChildrenTest()[i], depth + 1);
            }
        }

        public void TesteSwapElem()
        {
            IEnumerator filhos = tree.Children(tree.Root());
            filhos.MoveNext();
            tree.SwapElements(tree.Root(), (No)filhos.Current);
        }

        public int TesteAltura()
        {
            return tree.Height();
        }

        public IEnumerator TesteElements()
        {
            return tree.Elements();
        }

        public IEnumerator TesteNos()
        {
            return tree.Nos();
        }

        public int TesteTamanho()
        {
            return tree.Size();
        }

        public object TesteReplace(No n, object o)
        {
            return tree.Replace(n, o);
        }
    }
}
