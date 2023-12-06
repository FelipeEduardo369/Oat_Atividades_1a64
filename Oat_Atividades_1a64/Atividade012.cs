using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade012
    {
        public void Atividade12()

        {   Console.WriteLine("PROGRAMA MÓDULO NÚMERO");
            Console.WriteLine("Informe um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0) {
                Console.WriteLine($"Número igual a {numero}");
            }
            else
            {
                numero = numero * (-1);
                Console.WriteLine($"Número é igual a {numero}");
            }
            Console.ReadKey();  
        }
    }

}
