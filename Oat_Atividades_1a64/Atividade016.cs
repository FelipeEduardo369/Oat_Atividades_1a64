using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade016
    {
        public void Atividade16()
        {
            Console.WriteLine("PROGRAMA MAIOR E MENOR NÚMERO");
            Console.WriteLine("Informe o primeiro valor:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("informe o segundo valor:");
            double num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"Maior número = {num1}, menor número = {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"Maior número = {num2}, menor número = {num1}");
            }

            else
            {
                Console.WriteLine($"Os dois números são iguais({num1})");
            }
            Console.ReadKey();
        }
        
    }
}
