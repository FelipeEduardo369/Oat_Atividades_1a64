using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade043
    {
        public void Atividade43()
        {
            Console.WriteLine("PROGRAMA PROGRESSÃO DE GRÃOS NUM TABULEIRO DE XADREZ");
            int quadrados = 64;
            ulong primeiroTermo = 1;
            ulong resultado = primeiroTermo * ((ulong)Math.Pow(2, quadrados) - 1) / (2 - 1);

           
            Console.WriteLine($"O número total de grãos a serem pagos para o monge levando em conta um tabuleiro com 64 quadrados é igual a {resultado}.");

        }
    }
}
