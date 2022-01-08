using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADGrafo
{
    interface IGrafo
    {
        public Vertice[] FinalVertices(Aresta a);
        public Vertice Oposto(Vertice v, Aresta a);
        public bool IsAdjacente(Vertice v, Vertice w);
        public object Substituir(Vertice v, object x);
        public object Substituir(Aresta a, object x);
        public Vertice InserirVertice(object o);
        public Aresta InserirAresta(Vertice v, Vertice w, object o);
        public Aresta InserirArestaDirecionada(Vertice inicio, Vertice final, object o);
        public bool IsDirecionada(Aresta a);
        public object RemoveVertice(Vertice v);
        public object RemoveAresta(Aresta a);
        public IEnumerator ArestasIncidentes(Vertice v);
        public IEnumerator Vertices();
        public IEnumerator Arestas();
    }
}
