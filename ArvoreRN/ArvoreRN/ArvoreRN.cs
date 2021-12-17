using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreRN
{
    public class ArvoreRN
    {
        private Node raiz;
        public Node Raiz
        {
            get { return raiz; }
            set { raiz = value; }
        }

        public void Inserir(int data)
        {
            if (raiz != null) raiz.Inserir(data, this);
            else
            {
                raiz = new Node(data);
                raiz.Cor = 'N';
            }
        }

        public Node Encontrar(int data)
        {
            if (raiz != null) return raiz.Encontrar(data);
            else return null;
        }

        public Node EncontrarRecur(int data)
        {
            if (raiz != null) return raiz.EncontrarRecur(data);
            else return null;
        }

        private Node GetSucessor(Node no)
        {
            Node parenteDoSucessor = no;
            Node sucessor = no;
            Node noAtual = no.Right;

            while (noAtual != null)
            {
                parenteDoSucessor = sucessor;
                sucessor = noAtual;
                noAtual = noAtual.Left;
            }

            if (sucessor != no.Right)
            {
                parenteDoSucessor.Left = sucessor.Right;
                sucessor.Right = no.Right;
            }

            sucessor.Left = no.Left;

            return sucessor;
        }

        public void Remover(int data)
        {
            Node noAtual = raiz;
            Node parente = raiz;
            bool isLeftChild = false;

            if (noAtual == null) return;

            while (noAtual != null && noAtual.Data != data)
            {
                parente = noAtual;

                if (data < noAtual.Data)
                {
                    noAtual = noAtual.Left;
                    isLeftChild = true;
                }
                else
                {
                    noAtual = noAtual.Right;
                    isLeftChild = false;
                }
            }

            if (noAtual == null) return;

            if (noAtual.Right == null && noAtual.Left == null)
            {
                if (noAtual == raiz) raiz = null;
                else
                {
                    if (isLeftChild) parente.Left = null;
                    else parente.Right = null;
                    noAtual.Pai = null;
                }
            }
            else if (noAtual.Right == null)
            {
                if (noAtual == raiz) raiz = noAtual.Left;
                else
                {
                    if (isLeftChild) parente.Left = noAtual.Left;
                    else parente.Right = noAtual.Left;
                    noAtual.Pai = null;
                }
            }
            else if (noAtual.Left == null)
            {
                if (noAtual == raiz) raiz = noAtual.Right;
                else
                {
                    if (isLeftChild) parente.Left = noAtual.Right;
                    else parente.Right = noAtual.Right;
                    noAtual.Pai = null;
                }
            }
            else
            {
                Node sucessor = GetSucessor(noAtual);

                if (noAtual == raiz)
                    raiz = sucessor;
                else if (isLeftChild) parente.Left = sucessor;
                else parente.Right = sucessor;
                noAtual.Pai = null;
            }
        }

        public void SoftDelete(int data)
        {
            Node paraRemover = Encontrar(data);
            if (paraRemover != null) paraRemover.Delete();
        }

        public void Mostrar()
        {
            Mostrar(raiz);
        }

        // Mostrar Árvore de lado
        private void Mostrar(Node n, int pos = 0)
        {
            if (n == null)
            {
                for (int i = 0; i < pos; ++i)
                    Console.Write("\t");
                Console.WriteLine("*[N]");
                return;
            }
            Mostrar(n.Right, pos + 1);
            for (int i = 0; i < pos; ++i)
                Console.Write("\t");
            Console.WriteLine(n.Data + "[" + n.Cor + "]");
            Mostrar(n.Left, pos + 1);
        }
    }
}
