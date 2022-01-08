using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADGrafo
{
    class TADGrafo : IGrafo
    {
        // Implementação: Lista de adjacência
        private List<Vertice> listaDeVertices;
        private List<Aresta> listaDeArestas;

        public TADGrafo()
        {
            listaDeVertices = new List<Vertice>();
            listaDeArestas = new List<Aresta>();
        }

        public Vertice[] FinalVertices(Aresta a)
        {
            Vertice[] vertices = new Vertice[2];
            vertices[0] = a.Inicio;
            vertices[1] = a.Final;
            return vertices;
        }

        public Vertice Oposto(Vertice v, Aresta a)
        {
            try
            {
                if (a.Inicio == v) return a.Final;
                else return a.Inicio;
            }
            catch
            {
                throw new EArestaNaoIncidente("A aresta informada não é incidente no vértice");
            }
        }

        public bool IsAdjacente(Vertice v, Vertice w)
        {
            foreach (Sucessor s in v.ListaDeSucessores)
                if (s.VerticeSucessor == w) return true;
            foreach (Sucessor s in w.ListaDeSucessores)
                if (s.VerticeSucessor == v) return true;
            return false;
        }

        public object Substituir(Vertice v, object x)
        {
            object elemAntes = v.Elemento;
            v.Elemento = x;
            return elemAntes;
        }

        public object Substituir(Aresta a, object x)
        {
            object valorAntes = a.Valor;
            a.Valor = x;
            return valorAntes;
        }

        public Vertice InserirVertice(object o)
        {
            Vertice v = new Vertice(o);
            listaDeVertices.Add(v);
            return v;
        }

        public Aresta InserirAresta(Vertice v, Vertice w, object o)
        {
            // Aresta bidirecional (mesma coisa que aresta direcionada nos dois caminhos)
            Aresta a = new Aresta(v, w, o);
            listaDeArestas.Add(a);
            Sucessor s1 = new Sucessor(w, a);
            Sucessor s2 = new Sucessor(v, a);
            v.ListaDeSucessores.AddLast(s1);
            w.ListaDeSucessores.AddLast(s2);
            return a;
        }

        public Aresta InserirArestaDirecionada(Vertice inicio, Vertice final, object o)
        {
            Aresta a = new Aresta(inicio, final, o);
            a.IsDirecionada = true;
            listaDeArestas.Add(a);
            Sucessor s = new Sucessor(final, a);
            inicio.ListaDeSucessores.AddLast(s);
            return a;
        }

        public bool IsDirecionada(Aresta a)
        {
            if (a.IsDirecionada == true) return true;
            else return false;
        }

        public object RemoveVertice(Vertice v)
        {
            // Remove todas as arestas incidentes
            foreach (Aresta a in listaDeArestas)
            {
                if (a.Inicio == v || a.Final == v)
                    listaDeArestas.Remove(a);
            }

            listaDeVertices.Remove(v);
            return v.Elemento;
        }

        public object RemoveAresta(Aresta a)
        {
            Vertice inicio = a.Inicio;
            Vertice final = a.Final;

            // Verifica se a aresta é bidirecionada (tem que remover dos dois caminhos)
            if (a.IsDirecionada == false)
            {
                Sucessor s1 = new Sucessor(final, a);
                Sucessor s2 = new Sucessor(inicio, a);
                inicio.ListaDeSucessores.Remove(s1);
                final.ListaDeSucessores.Remove(s2);
            }
            else 
            {
                Sucessor s = new Sucessor(final, a);
                inicio.ListaDeSucessores.Remove(s);
            }

            listaDeArestas.Remove(a);
            return a.Valor;
        }

        public IEnumerator ArestasIncidentes(Vertice v)
        {
            List<Aresta> arestasIncidentes = new List<Aresta>();
            foreach (Aresta a in listaDeArestas)
            {
                if (a.Inicio == v || a.Final == v)
                    arestasIncidentes.Add(a);
            }

            return arestasIncidentes.GetEnumerator();
        }

        public IEnumerator Vertices()
        {
            return listaDeVertices.GetEnumerator();
        }

        public IEnumerator Arestas()
        {
            return listaDeArestas.GetEnumerator();
        }
    }
}
