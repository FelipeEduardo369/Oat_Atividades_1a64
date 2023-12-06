using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade014
    {
        public void Atividade14()
        {
            Console.WriteLine("PROGRAMA DIFERENÇA ENTRE NÚMEROS");
            Console.WriteLine("Informe um número:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe outro número maior ou menor:");
            double num2 = double.Parse(Console.ReadLine());
            double resultado = 0;
            if (num1 > num2)
            {
                resultado = num1 - num2;
                Console.WriteLine($"A diferença entre o maior e menor número: {num1} - {num2} = {resultado}");
            }
            if (num1 < num2)
            {
                resultado = num2 - num1;
                Console.WriteLine($"A diferença entre o maior e o menor número: {num2} - {num1} = {resultado}");
            }

        }
    }
}
