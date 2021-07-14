using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreGenerica
{
    public class ArvoreSimples
    {

        // Atributos da Árvore
        No raiz;
        int tamanho;

        // Construtor
        public ArvoreSimples(object o)
        {
            raiz = new No(null, o);
            tamanho = 1;
        }

        public No root()
        {
            return raiz;
        }

        public No parent(No v)
        {
            return v.parent();
        }

        public IEnumerator children(No v)
        {
            return v.children();
        }

        public bool isInternal(No v)
        {
            return v.childrenNumber() > 0;
        }

        public bool isExternal(No v)
        {
            return v.childrenNumber() == 0;
        }

        public bool isRoot(No v)
        {
            return v == raiz;
        }

        public void addChild(No v, object o)
        {
            No novo = new No(v, o);
            v.addChild(novo);
            tamanho++;
        }

        public object remove(No v)
        {
            No pai = v.parent();
            if ((pai != null) || isExternal(v))
            {
                pai.removeChild(v);
            }
            else
            {
                throw new SystemException();
            }

            object o = v.element();
            tamanho--;
            return o;
        }

        public void swapElements(No v, No w)
        {
            object o = v.element();
            v.setElement(w.element());
            w.setElement(o);
        }

        public int depth(No v)
        {
            int profundidade = this.profundidade(v);
            return profundidade;
        }

        private int profundidade(No v)
        {
            if (v == raiz)
            {
                return 0;
            }
            else
            {
                return 1 + profundidade(v.parent());
            }
        }

        public int height()
        {
            return height(raiz);
        }

        private int height(No n)
        {
            if (isExternal(n)) return 0;
            else
            {
                int altura = 0;
                IEnumerator filhos = n.children();
                while (filhos.MoveNext())
                {
                    altura = Math.Max(altura, height((No)filhos.Current));
                }

                return 1 + altura;
            }
        }

        public IEnumerator elements()
        {
            //método exercício
            return null;
        }

        public IEnumerator Nos()
        {
            //método exercício
            return null;
        }

        public int size()
        {
            //método exercício
            return 0;
        }

        public bool isEmpty()
        {
            return false;
        }

        public object replace(No v, object o)
        {
            v.setElement(o);
            return v.element();
        }
    }
}
