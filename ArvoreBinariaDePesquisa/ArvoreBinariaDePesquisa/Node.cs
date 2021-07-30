using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinariaDePesquisa
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

        private bool isRoot;
        public bool IsRoot { 
            get { return isRoot; } 
            set { isRoot = value; }
        }

        public void Inserir(int value)
        {
            if (value >= data)
            {
                if (right == null) right = new Node(value);
                else right.Inserir(value);
            }
            else
            {
                if (left == null) left = new Node(value);
                else left.Inserir(value);
            }
        }

        public void TravessiaEmOrdem()
        {
            if (left != null) left.TravessiaEmOrdem();

            if (!isDeleted)
            {
                if (isRoot == true) Console.Write("(" + data + ") ");
                else Console.Write(data + " ");
            }
            
            if (right != null) right.TravessiaEmOrdem();
        }

        public void TravessiaPreOrdem()
        {
            if (!isDeleted)
            {
                if (isRoot == true) Console.Write("(" + data + ") ");
                else Console.Write(data + " ");
            }

            if (left != null) left.TravessiaPreOrdem();           

            if (right != null) right.TravessiaPreOrdem();
        }

        public void TravessiaPosOrdem()
        {
            if (left != null) left.TravessiaPreOrdem();

            if (right != null) right.TravessiaPreOrdem();

            if (!isDeleted)
            {
                if (isRoot == true) Console.Write("(" + data + ") ");
                else Console.Write(data + " ");
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
