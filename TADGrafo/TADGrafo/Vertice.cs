using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADGrafo
{
    class Vertice
    {
        public object Elemento { get; set; }
        public LinkedList<Sucessor> ListaDeSucessores { get; set; }

        public Vertice(object o)
        {
            Elemento = o;
            ListaDeSucessores = new LinkedList<Sucessor>();
        }
    }
}
