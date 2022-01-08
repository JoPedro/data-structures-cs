using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADGrafo
{
    class Sucessor
    {
        public Vertice VerticeSucessor { get; set; }
        public Aresta ArestaIncidente { get; set; }

        public Sucessor(Vertice v, Aresta a)
        {
            VerticeSucessor = v;
            ArestaIncidente = a;
        }
    }
}
