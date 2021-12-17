using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreAVL
{
    public class Node
    {
        private int data;
        public int Data { get { return data; } }

        private int fb;
        public int Fb { 
            get { return fb; } 
            set { fb = value; }
        }

        public Node(int value)
        {
            data = value;
            left = null;
            right = null;
            pai = null;
            fb = 0;
        }

        private Node pai;
        public Node Pai { 
            get { return pai; } 
            set { pai = value; }
        }

        private Node left;
        public Node Left { 
            get { return left; }
            set { left = value; } 
        }

        private Node right;
        public Node Right
        {
            get { return right; }
            set { right = value; }
        }

        private bool isDeleted;
        public bool IsDeleted { get { return isDeleted; } }

        public bool IsRoot(Node n)
        {
            if (n.Pai == null) return true;
            else return false;
        }

        public bool IsFilhoEsquerdo(Node n)
        {
            if (n.Pai.Data > n.Data) return true;
            else return false;
        }

        public void Inserir(int value, ArvoreAVL tree)
        {
            if (value >= data)
            {
                if (right == null) 
                {
                    Node newNode  = new Node(value);
                    right = newNode;
                    newNode.Pai = this;
                    AtualizarFB(newNode, tree);
                }
                else right.Inserir(value, tree);
            }
            else
            {
                if (left == null) 
                {
                    Node newNode = new Node(value);
                    left = newNode;
                    newNode.Pai = this;
                    AtualizarFB(newNode, tree);
                }
                else left.Inserir(value, tree);
            }
        }

        public void AtualizarFB(Node noAtual, ArvoreAVL tree)
        {
            do
            {
                if (IsRoot(noAtual) == true)
                    break;
                if (IsFilhoEsquerdo(noAtual) == true)
                {
                    noAtual.Pai.Fb++;
                    if (noAtual.Pai.Fb == 2 && noAtual.Fb >= 0)
                        RotacaoDS(noAtual, tree);
                    else if (noAtual.Pai.Fb == 2 && noAtual.Fb <= 0)
                        RotacaoDD(noAtual.Right, tree);
                    if (IsRoot(noAtual) == true)
                        break;
                    noAtual = noAtual.Pai;
                }
                else
                {
                    noAtual.Pai.Fb--;
                    if (noAtual.Pai.Fb == -2 && noAtual.Fb <= 0)
                        RotacaoES(noAtual, tree);
                    else if (noAtual.Pai.Fb == -2 && noAtual.Fb >= 0)
                        RotacaoDE(noAtual.Left, tree);
                    if (IsRoot(noAtual) == true)
                        break;
                    noAtual = noAtual.Pai;
                }
            } while (noAtual.Fb != 0);
        }

        public void AtualizarFBRemocao(Node noAtual, ArvoreAVL tree)
        {
            do
            {
                if (IsRoot(noAtual) == true)
                    break;
                if (IsFilhoEsquerdo(noAtual) == true)
                {
                    noAtual.Pai.Fb--;
                    if (noAtual.Pai.Fb == -2 && noAtual.Fb <= 0)
                        RotacaoES(noAtual, tree);
                    else if (noAtual.Pai.Fb == -2 && noAtual.Fb >= 0)
                        RotacaoDE(noAtual.Left, tree);
                    if (IsRoot(noAtual) == true)
                        break;
                    noAtual = noAtual.Pai;
                }
                else
                {
                    noAtual.Pai.Fb++;
                    if (noAtual.Pai.Fb == 2 && noAtual.Fb >= 0)
                        RotacaoDS(noAtual, tree);
                    else if (noAtual.Pai.Fb == 2 && noAtual.Fb <= 0)
                        RotacaoDD(noAtual.Right, tree);
                    if (IsRoot(noAtual) == true)
                        break;
                    noAtual = noAtual.Pai;
                }
            } while (noAtual.Fb == 0);
        }

        public void RotacaoES(Node n, ArvoreAVL tree)
        {
            Node nAvo = n.Pai.Pai;
            Node nOldLeft = null;
            if (n.Left != null)
                nOldLeft = n.Left;
            n.Left = n.Pai;
            n.Pai = nAvo;
            n.Left.Right = nOldLeft;
            n.Left.Pai = n;
                
            if (IsRoot(n) == true)
                tree.Raiz = n;
            else
            {
                if (n.Pai.Data < n.Data)
                    n.Pai.Right = n;
                else
                    n.Pai.Left = n;
            }

            n.Left.Fb = n.Left.Fb + 1 - Math.Min(n.Fb, 0);
            n.Fb = n.Fb + 1 + Math.Max(n.Left.Fb, 0);
        }

        public void RotacaoDE(Node n, ArvoreAVL tree)
        {
            RotacaoDS(n, tree);
            RotacaoES(n, tree);
        }

        public void RotacaoDD(Node n, ArvoreAVL tree)
        {
            RotacaoES(n, tree);
            RotacaoDS(n, tree);
        }
 
        public void RotacaoDS(Node n, ArvoreAVL tree)
        {
            Node nAvo = n.Pai.Pai;
            Node nOldRight = null;
            if (n.Right != null)
                nOldRight = n.Right;
            n.Right = n.Pai;
            n.Pai = nAvo;
            n.Right.Left = nOldRight;
            n.Right.Pai = n;

            if (IsRoot(n) == true)
                tree.Raiz = n;
            else
            {
                if (n.Pai.Data < n.Data)
                    n.Pai.Right = n;
                else
                    n.Pai.Left = n;
            }

            n.Right.Fb = n.Right.Fb - 1 - Math.Max(n.Fb, 0);
            n.Fb = n.Fb - 1 + Math.Min(n.Right.Fb, 0);
        }

        public Node Encontrar(int value)
        {
            Node noAtual = this;

            while (noAtual != null)
            {
                if (value == noAtual.data && isDeleted == false) return noAtual;
                else if (value > noAtual.data) noAtual = noAtual.right;
                else noAtual = noAtual.left;
            }

            return null;
        }

        public Node EncontrarRecur(int value)
        {
            if (value == data && isDeleted == false) return this;
            else if (value < data && left != null) return left.EncontrarRecur(value);
            else if (right != null) return right.EncontrarRecur(value);
            else return null;
        }  
        
        public void Delete()
        {
            isDeleted = true;
        }
    }
}
