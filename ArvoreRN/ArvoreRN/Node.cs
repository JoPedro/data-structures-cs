using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreRN
{
    public class Node
    {
        private int data;
        public int Data { get { return data; } }

        public Node(int value)
        {
            data = value;
            left = null;
            right = null;
            pai = null;
            cor = 'R';
            isDuploNegro = false;
        }

        private char cor;
        public char Cor { 
            get { return cor; } 
            set { cor = value; }
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

        private bool isDuploNegro;
        public bool IsDuploNegro
        {
            get { return isDuploNegro; }
            set { isDuploNegro = value; }
        }

        private bool isDeleted;
        public bool IsDeleted 
        { 
            get { return isDeleted; } 
            set { isDeleted = value; }
        }

        public static bool IsRoot(Node n)
        {
            if (n.Pai == null) return true;
            else return false;
        }

        public static bool IsFilhoEsquerdo(Node n)
        {
            if (n != null && n.Pai.Data > n.Data) return true;
            else return false;
        }

        public static bool IsFolha(Node n)
        {
            if (n.Left == null && n.Right == null) return true;
            else return false;
        }

        public static bool IsNegro(Node n)
        {
            if (n == null || n.Cor == 'N') return true;
            else return false;
        }

        public void Inserir(int value, ArvoreRN tree)
        {
            if (value >= data)
            {
                if (right == null) 
                {
                    Node newNode  = new Node(value);
                    right = newNode;
                    newNode.Pai = this;

                    Recolorir(newNode, tree);
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

                    Recolorir(newNode, tree);
                }
                else left.Inserir(value, tree);
            }
        }

        public void Recolorir(Node newNode, ArvoreRN tree)
        {
            Node pai;
            Node avo;

            if (!IsRoot(newNode)) pai = newNode.Pai;
            else pai = null;

            if (!IsRoot(pai)) avo = pai.Pai;
            else avo = null;

            Node tio;

            if (!IsRoot(pai))
            {
                if (IsFilhoEsquerdo(pai) && avo.Right != null) tio = avo.Right;
                else if (!IsFilhoEsquerdo(pai) && avo.Left != null) tio = avo.Left;
                else tio = null;
            }
            else tio = null;

            // Caso 1 (pai negro)
            if (IsNegro(pai))
                return;
            // Caso 2 (pai rubro avo negro tio rubro)
            else if ((pai.Cor == 'R' && IsNegro(avo)) && (tio != null && tio.Cor == 'R'))
            {
                if (!IsRoot(avo)) avo.Cor = 'R';
                tio.Cor = 'N';
                pai.Cor = 'N';

                if (avo.Pai != null && avo.Pai.Cor == 'R') Recolorir(avo, tree);
            }
            // Caso 3 (pai rubro avo negro tio negro)
            else if ((pai.Cor == 'R' && IsNegro(avo)) && IsNegro(tio))
            {
                // Caso 3a
                if (IsFilhoEsquerdo(newNode) && IsFilhoEsquerdo(pai))
                {
                    RotacaoDS(pai, tree);
                    pai.Cor = 'N';
                    pai.Right.Cor = 'R';
                }
                // Caso 3b
                else if (!IsFilhoEsquerdo(newNode) && !IsFilhoEsquerdo(pai))
                {
                    RotacaoES(pai, tree);
                    pai.Cor = 'N';
                    pai.Left.Cor = 'R';
                }
                // Caso 3c
                else if (IsFilhoEsquerdo(newNode) && !IsFilhoEsquerdo(pai))
                {
                    RotacaoDE(newNode, tree);
                    newNode.Cor = 'N';
                    newNode.Left.Cor = 'R';
                }
                // Caso 3d
                else
                {
                    RotacaoDD(newNode, tree);
                    newNode.Cor = 'N';
                    newNode.Right.Cor = 'R';
                }
            }
        }

        public static void RotacaoES(Node n, ArvoreRN tree)
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
        }

        public static void RotacaoDE(Node n, ArvoreRN tree)
        {
            RotacaoDS(n, tree);
            RotacaoES(n, tree);
        }

        public static void RotacaoDD(Node n, ArvoreRN tree)
        {
            RotacaoES(n, tree);
            RotacaoDS(n, tree);
        }
 
        public static void RotacaoDS(Node n, ArvoreRN tree)
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
