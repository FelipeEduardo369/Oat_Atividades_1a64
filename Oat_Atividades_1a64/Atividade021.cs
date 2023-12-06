using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade021
    {
        public void Atividade21()
        {
            int num = 1;
           while (num == 1){
                Console.Clear();
                Console.WriteLine("PROGRAMA NÚMERO POSITIVO E NEGATIVO");
                Console.WriteLine("Informe um número inteiro:");
                int numero = int.Parse(Console.ReadLine());
                if (numero < 0)
                {
                    Console.WriteLine("Número digitado é negativo.");

                }
                else
                {
                    Console.WriteLine("Número digitado é positivo.");
                }
                Console.WriteLine("Digite 1 para rodar o programa novamente, qualquer outro número para sair:");
                num = int.Parse(Console.ReadLine()) ;
            }

        }
    }
}
