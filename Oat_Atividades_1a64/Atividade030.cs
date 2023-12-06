using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade030
    {
        public void Atividade30()
        {
            Console.WriteLine("PROGRAMA TABUADA");
            Console.WriteLine("Digite o número para saber a sua tabuada:");
            int tabuada = int.Parse(Console.ReadLine());
            int resultado = 0;

            tab(ref tabuada, ref resultado);
            
        }
        static void tab(ref int a,  ref int b)
        {
            for (int i = 1; i <= 10 ; i++)
            {   
                b = a * i;
                Console.WriteLine($"{a} X {i} = {b}");
            }
        }
    }
}
