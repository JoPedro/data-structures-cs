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

        public object element()
        {
            return o;
        }

        public No parent()
        {
            return pai;
        }

        public void setElement(object o)
        {
            this.o = o;
        }

        public void addChild(No o)
        {

            filhos.Add(o);
        }

        public void removeChild(No o)
        {
            filhos.Remove(o);
        }

        public int childrenNumber()
        {
            return filhos.Count;
        }

        public IEnumerator children()
        {
            return filhos.GetEnumerator();
        }
    }
}
