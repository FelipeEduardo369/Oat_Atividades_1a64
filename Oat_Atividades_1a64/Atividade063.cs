using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade063
    {
        public void Atividade63()
        {
            Console.WriteLine("PROGRAMA PAR ÍMPAR");
            Console.WriteLine("Informe um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            Verifica(ref numero);


        }
        static void Verifica(ref int x)
        {
            if (x % 2 == 0)
            {
               Console.WriteLine($"O número {x} é par.");
            }
            else 
            {
                Console.WriteLine($"O número {x} é ímpar.");
            }
        }
    }
}
