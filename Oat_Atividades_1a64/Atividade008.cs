using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade008
    {
        public void Atividade08()
        {
            Console.WriteLine("PROGRAMA VOLUME LATA DE ÓLEO");
            Console.WriteLine("Informe a altura da lata:");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o raio da lata:");
            double raio = double.Parse(Console.ReadLine());

            double volume = 3.14159 * raio * raio * altura;
            Console.WriteLine($"O volume da lata informada é igual a {volume}.");
            Console.ReadKey();        
        }

    }
}
