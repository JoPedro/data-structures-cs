using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADGrafo
{
    class Aresta
    {
        public object Valor { get; set; }
        public Vertice Inicio { get; set; }
        public Vertice Final { get; set; }
        public bool IsDirecionada { get; set; }
        
        public Aresta(Vertice v, Vertice w, object o)
        {
            Inicio = v;
            Final = w;
            Valor = o;
            IsDirecionada = false;
        }
    }
}
