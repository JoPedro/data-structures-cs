using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDataStruct
{
    interface IPilhaRedBlack
    {
        /* Pilha Vermelha e Preta no mesmo array: 
         * Vermelha começa a partir do primeiro elemento, 
         * Preta começa a partir do último elemento.
         * 
         * Exemplo: Pilha vermelha -> {1, 2, 3, 4, , , , , e, d, c, b, a} <- Pilha preta
         * 
         * O Array duplica de tamanho quando ultrapassa sua capacidade.
         */

        public int Size();
        public bool IsEmptyRed();
        public bool IsEmptyBlack();
        public object TopRed();
        public object TopBlack();
        public void PushRed(object o);
        public void PushBlack(object o);
        public object PopRed();
        public object PopBlack();
    }
}
