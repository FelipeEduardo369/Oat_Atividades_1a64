using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade042
    {
        public void Atividade42()
        {
            Console.WriteLine("PROGRAMA MAIOR E MENOR NÚMERO");
            Console.WriteLine("informe os números desejados um por um:");
            double numeros = double.Parse(Console.ReadLine());
            double numMaior = numeros;
            double numMenor = numeros;
            do
            {
                Console.WriteLine("Informe um número: (0 para terminar");
                numeros = double.Parse(Console.ReadLine());
                if (numeros == 0)
                {
                    break;
                }
                if (numeros > numMaior)
                {
                    numMaior = numeros;
                }
                if (numeros < numMenor)
                {
                    numMenor = numeros;
                }

            } while (numeros != 0);
            Console.WriteLine($"O maior número digitado foi {numMaior}\n" +
                $"O menor número digitado foi {numMenor}");

            Console.ReadKey();
            
        }
    }
}
