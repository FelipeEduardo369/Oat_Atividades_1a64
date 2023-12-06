using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade006
    {
        public void Atividade06()
        {
            Console.WriteLine("PROGRAMA COVERSÃO EM FAHRENHEIT");
            Console.WriteLine("Informe a temperatura em graus celsius:");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (9 * celsius + 160) / 5;

            Console.WriteLine($"{celsius} graus celsius é igual a {fahrenheit} em graus fahrenheit");
            Console.ReadKey();
        }
    }
}
