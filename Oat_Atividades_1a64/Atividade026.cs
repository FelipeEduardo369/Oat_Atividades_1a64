using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade026
    {
        public void Atividade26()
        {
            Console.WriteLine("PROGRAMA NÚMEROS NA ORDEM DECRESCENTE");
             int [] numeros = new int[100];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i+1;
            }

            Array.Reverse(numeros);

            foreach (int numero in  numeros)
            {
                Console.WriteLine(numero);
            }
            
            
        }
        
    }
}
