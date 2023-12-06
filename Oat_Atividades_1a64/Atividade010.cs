using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade010
    {
        public void Atividade10()
        {
            Console.WriteLine("PROGRAMA RELAÇÃO ENTRE OS NÚMEROS");
            Console.WriteLine("Informe o primeiro valor:");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor:");
            double valor2 = double.Parse(Console.ReadLine());
            
            if (valor1 == valor2)
            {
                Console.WriteLine("Os dois números são iguais");
            }

            if (valor1 < valor2)
            {
                Console.WriteLine($"{valor1} é menor que {valor2}");
            }
            if (valor1 > valor2)
            {
                Console.WriteLine($"{valor1} é maior que {valor2}");
            }
            Console.ReadKey();
        }
    }
}
