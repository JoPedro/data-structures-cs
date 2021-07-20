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

        public No Root()
        {
            return raiz;
        }

        public No Parent(No v)
        {
            return v.Parent();
        }

        public IEnumerator Children(No v)
        {
            return v.Children();
        }

        public bool IsInternal(No v)
        {
            return v.ChildrenNumber() > 0;
        }

        public bool IsExternal(No v)
        {
            return v.ChildrenNumber() == 0;
        }

        public bool IsRoot(No v)
        {
            return v == raiz;
        }

        public void AddChild(No v, object o)
        {
            No novo = new No(v, o);
            v.AddChild(novo);
            tamanho++;
        }

        public object Remove(No v)
        {
            No pai = v.Parent();
            if ((pai != null) || IsExternal(v))
            {
                pai.RemoveChild(v);
            }
            else
            {
                throw new SystemException();
            }

            object o = v.Element();
            tamanho--;
            return o;
        }

        public void SwapElements(No v, No w)
        {
            object o = v.Element();
            v.SetElement(w.Element());
            w.SetElement(o);
        }

        public int Depth(No v)
        {
            int profundidade = this.Profundidade(v);
            return profundidade;
        }

        private int Profundidade(No v)
        {
            if (v == raiz)
            {
                return 0;
            }
            else
            {
                return 1 + Profundidade(v.Parent());
            }
        }

        public int Height()
        {
            return Height(raiz);
        }

        private int Height(No n)
        {
            if (IsExternal(n)) return 0;
            else
            {
                int altura = 0;
                IEnumerator filhos = n.Children();
                while (filhos.MoveNext())
                {
                    altura = Math.Max(altura, Height((No)filhos.Current));
                }

                return 1 + altura;
            }
        }

        public IEnumerator Elements()
        {
            ArrayList elems = new ArrayList();
            Elements(raiz, elems);
            return elems.GetEnumerator();
        }

        private void Elements(No n, ArrayList elems)
        {
            elems.Add(n.Element());
            if (IsInternal(n))
            {
                IEnumerator filhos = n.Children();
                while (filhos.MoveNext())
                    Elements((No)filhos.Current, elems);
            }
        }

        public IEnumerator Nos()
        {
            ArrayList nos = new ArrayList();
            Nos(raiz, nos);
            return nos.GetEnumerator();
        }

        private void Nos(No n, ArrayList nos)
        {
            nos.Add(n);
            if (IsInternal(n))
            {
                IEnumerator filhos = n.Children();
                while (filhos.MoveNext())
                    Nos((No)filhos.Current, nos);
            }
        }

        public int Size()
        {
            return tamanho;
        }

        public bool IsEmpty()
        {
            return false;
        }

        public object Replace(No v, object o)
        {
            v.SetElement(o);
            return v.Element();
        }
    }
}
