using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinariaDePesquisa
{
    class TesteArvoreBinaria
    {
        // Classe para testes dos métodos
        private ArvoreBinaria tree;

        public TesteArvoreBinaria()
        {
            tree = new ArvoreBinaria();
        }
        
        public void Teste()
        {         
            tree.Inserir(75);
            tree.Inserir(57);
            tree.Inserir(90);
            tree.Inserir(32);
            tree.Inserir(7);
            tree.Inserir(44);
            tree.Inserir(60);
            tree.Inserir(86);
            tree.Inserir(93);
            tree.Inserir(99);

            tree.Mostrar();

            //Console.WriteLine("Travessia em ordem: Esquerda -> Raiz -> Direita");
            //tree.TravessiaEmOrdem();
            //Console.WriteLine();

            //Console.WriteLine("Travessia pré-ordem: Raiz -> Esquerda -> Direita");
            //tree.TravessiaPreOrdem();
            //Console.WriteLine();

            //Console.WriteLine("Travessia pós-ordem: Esquerda -> Direita -> Raiz");
            //tree.TravessiaPosOrdem();
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Encontre o número 99");
            //Node no = tree.Encontrar(99);
            //Console.WriteLine(no.Data);
            //Console.WriteLine();

            //Console.WriteLine("Encontre o número 99 recursivamente");
            //Node noRecur = tree.EncontrarRecur(99);
            //Console.WriteLine(noRecur.Data);
            //Console.WriteLine();

            //Console.WriteLine("Remova um nó folha: 44");
            //tree.Remover(44);
            //tree.TravessiaEmOrdem();
            //Console.WriteLine();

            //Console.WriteLine("Remova um nó com um filho único: 93");
            //tree.Remover(93);
            //tree.TravessiaEmOrdem();
            //Console.WriteLine();

            //Console.WriteLine("Remova um nó com dois filhos: 75");
            //tree.Remover(75);
            //tree.TravessiaEmOrdem();
            //Console.WriteLine();

            //Console.WriteLine("Realize um soft delete em um nó: 7");
            //tree.SoftDelete(7);
            //tree.TravessiaEmOrdem();
            //Console.WriteLine();
        }
    }
}
