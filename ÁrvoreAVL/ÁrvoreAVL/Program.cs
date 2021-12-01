namespace ArvoreAVL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Árvore Binária AVL\n");

            TesteArvoreAVL treeTeste = new TesteArvoreAVL();

            // Teste realizado utilizando a classe de testes
            Console.WriteLine("Obs.: A árvore está mostrada de lado.\n");
            treeTeste.Teste();
            Console.WriteLine();
        }
    }
}
