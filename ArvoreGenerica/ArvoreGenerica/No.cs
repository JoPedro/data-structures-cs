using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreGenerica
{
    public class No
    {

        private object o;
        private No pai;
        private ArrayList filhos = new ArrayList();

        public No(No pai, object o)
        {
            this.pai = pai;
            this.o = o;
        }

        public object Element()
        {
            return o;
        }

        public No Parent()
        {
            return pai;
        }

        public void SetElement(object o)
        {
            this.o = o;
        }

        public void AddChild(No o)
        {

            filhos.Add(o);
        }

        public void RemoveChild(No o)
        {
            filhos.Remove(o);
        }

        public int ChildrenNumber()
        {
            return filhos.Count;
        }

        public IEnumerator Children()
        {
            return filhos.GetEnumerator();
        }

        public ArrayList ChildrenTest()
        {
            return filhos;
        }
    }
}
