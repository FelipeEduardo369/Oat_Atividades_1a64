using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade007
    {
        public void Atividade07()
        {
            Console.WriteLine("PROGRAMA CONVERSÃO EM CELSIUS");
            Console.WriteLine("Informe a temperatura em graus fahrenheit:");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"{fahrenheit} graus fahrenheit é igual a {celsius} graus celsius.");
            Console.ReadKey();
        }
    }
}
