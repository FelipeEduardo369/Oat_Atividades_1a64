using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade035
    {
        public void Atividade35()
        {
            Console.WriteLine("PROGRAMA MÚLTIPLOS DE 10");

            int[]numeros=new int[100];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i + 1;
               

                if (i % 10 == 0)
                {
                    Console.WriteLine("Esse número é múltiplo de 10");
                }
                Console.WriteLine(numeros[i]);
            }

        }
    }
}
