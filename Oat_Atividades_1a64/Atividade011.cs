using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade011
    {
        public void Atividade11()
        {
            Console.WriteLine("PROGRAMA TROCA DE VALORES");

            Console.WriteLine("Informe o valor de A:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B");
            int B = int.Parse(Console.ReadLine());

            A = B;
            B = A;
            Console.WriteLine($"Valor de A igual a {A}\n" +
                $"Valor de B igual a {B}");

            Console.ReadKey();  
        }
    }
}
