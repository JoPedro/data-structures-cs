using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreAVL
{
    class TesteArvoreAVL
    {
        // Classe para testes dos métodos
        private ArvoreAVL tree;

        public TesteArvoreAVL()
        {
            tree = new ArvoreAVL();
        }
        
        public void Teste()
        {
            //tree.Inserir(10);
            //tree.Inserir(20);
            //tree.Inserir(30);
            //tree.Inserir(40);
            //tree.Inserir(50);
            //tree.Inserir(25);
            //tree.Inserir(60);
            //tree.Inserir(70);
            //tree.Inserir(80);
            //tree.Inserir(90);

            tree.Inserir(8);
            tree.Inserir(6);
            tree.Inserir(20);
            tree.Inserir(2);
            tree.Inserir(7);
            tree.Inserir(11);
            tree.Inserir(29);
            tree.Inserir(3);
            tree.Inserir(10);
            tree.Inserir(12);
            tree.Inserir(24);
            tree.Inserir(32);
            tree.Inserir(9);
            tree.Inserir(22);
            tree.Inserir(31);

            tree.Remover(22);
            tree.Remover(31);
            tree.Remover(12);

            //tree.Inserir(6);
            //tree.Inserir(3);
            //tree.Inserir(8);
            //tree.Inserir(2);
            //tree.Inserir(4);
            //tree.Inserir(1);

            //tree.Inserir(32);
            //tree.Inserir(31);
            //tree.Inserir(35);
            //tree.Inserir(33);
            //tree.Inserir(36);
            //tree.Inserir(38);

            //tree.Inserir(50);
            //tree.Inserir(20);
            //tree.Inserir(70);
            //tree.Inserir(10);
            //tree.Inserir(30);
            //tree.Inserir(5);

            //tree.Inserir(50);
            //tree.Inserir(20);
            //tree.Inserir(80);
            //tree.Inserir(70);
            //tree.Inserir(90);
            //tree.Inserir(60);

            //tree.Inserir(50);
            //tree.Inserir(20);
            //tree.Inserir(90);
            //tree.Inserir(10);
            //tree.Inserir(40);
            //tree.Inserir(30);

            tree.Mostrar();
        }
    }
}
