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
                }

                RecolorirRemocao(noAtual, null);

                noAtual.Pai = null;
            }
            else if (noAtual.Right == null)
            {
                if (noAtual == raiz) raiz = noAtual.Left;
                else
                {
                    if (isLeftChild) parente.Left = noAtual.Left;
                    else parente.Right = noAtual.Left;
                }

                RecolorirRemocao(noAtual, null);

                noAtual.Pai = null;
            }
            else if (noAtual.Left == null)
            {
                if (noAtual == raiz) raiz = noAtual.Right;
                else
                {
                    if (isLeftChild) parente.Left = noAtual.Right;
                    else parente.Right = noAtual.Right;
                }

                RecolorirRemocao(noAtual, null);

                noAtual.Pai = null;
            }
            else
            {
                Node sucessor = GetSucessor(noAtual);

                if (noAtual == raiz)
                    raiz = sucessor;
                else if (isLeftChild) parente.Left = sucessor;
                else parente.Right = sucessor;

                RecolorirRemocao(noAtual, sucessor);

                noAtual.Pai = null;
            }
        }

        public void RecolorirRemocao(Node noAtual, Node sucessor)
        {
            Node paiSucessor;

            if (sucessor != null) paiSucessor = sucessor.Pai;
            else paiSucessor = null;

            // Situação 1
            if (noAtual.Cor == 'R' && sucessor != null && sucessor.Cor == 'R')
                return;
            // Situação 2
            else if (Node.IsNegro(noAtual) && sucessor != null && sucessor.Cor == 'R')
                sucessor.Cor = 'N';
            // Situação 3
            else if (Node.IsNegro(noAtual) && Node.IsNegro(sucessor))
            {
                Node irmaoSucessor;
                if (Node.IsFilhoEsquerdo(sucessor)) irmaoSucessor = paiSucessor.Right;
                else irmaoSucessor = paiSucessor.Left;

                Node sobrinhoE;
                if (irmaoSucessor != null && irmaoSucessor.Left != null)
                    sobrinhoE = irmaoSucessor.Left;
                else sobrinhoE = null;

                Node sobrinhoD;
                if (irmaoSucessor != null && irmaoSucessor.Right != null)
                    sobrinhoD = irmaoSucessor.Right;
                else sobrinhoD = null;

                // Caso 1
                if (irmaoSucessor != null && irmaoSucessor.Cor == 'R' && Node.IsNegro(paiSucessor))
                {
                    sucessor.IsDuploNegro = true;
                    Node.RotacaoES(irmaoSucessor, this);
                    irmaoSucessor.Cor = 'N';
                    paiSucessor.Cor = 'R';
                    // Caso 2b (recursivo)
                    RecolorirRemocao(noAtual, sucessor);
                }
                // Caso 2a
                else if (Node.IsNegro(irmaoSucessor) && Node.IsNegro(paiSucessor) && Node.IsNegro(sobrinhoE) && Node.IsNegro(sobrinhoD) && sucessor.IsDuploNegro)
                {
                    irmaoSucessor.Cor = 'R';
                    sucessor.IsDuploNegro = false;
                    if (paiSucessor.Pai != null) paiSucessor.IsDuploNegro = true;
                    // Resolver a partir do pai (recursivo)
                    RecolorirRemocao(noAtual, paiSucessor);
                }
                // Caso 2b
                else if (Node.IsNegro(irmaoSucessor) && paiSucessor.Cor == 'R' && Node.IsNegro(sobrinhoE) && Node.IsNegro(sobrinhoD) && sucessor.IsDuploNegro)
                {
                    irmaoSucessor.Cor = 'R';
                    paiSucessor.Cor = 'N';
                }
                // Caso 3
                else if (Node.IsNegro(irmaoSucessor) && paiSucessor != null && sobrinhoE != null && sobrinhoE.Cor == 'R' && Node.IsNegro(sobrinhoD))
                {
                    Node.RotacaoDS(sobrinhoE, this);
                    sobrinhoE.Cor = 'N';
                    irmaoSucessor.Cor = 'R';
                    // Caso 4 (recursivo)
                    RecolorirRemocao(noAtual, sucessor);
                }
                // Caso 4
                else if (Node.IsNegro(irmaoSucessor) && paiSucessor != null && sobrinhoD != null && sobrinhoD.Cor == 'R')
                {
                    char cor = paiSucessor.Cor;
                    Node.RotacaoES(irmaoSucessor, this);
                    irmaoSucessor.Cor = cor;
                    paiSucessor.Cor = 'N';
                    sobrinhoD.Cor = 'N';
                }
            }
            // Situação 4
            else
            {
                sucessor.Cor = 'R';
                SoftDelete(noAtual);
                noAtual.IsDuploNegro = true;
                // Prossiga Situação 3 (recursivo)
                RecolorirRemocao(noAtual, sucessor);
            }
        }

        public void SoftDelete(Node n)
        {
            n.IsDeleted = true;
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
