using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade022
    {
        public void Atividade22()
        {
            Console.WriteLine("PROGRAMA ARMAZENAMENTO DE NÚMERO");
            Console.WriteLine("Informe um número:");
            double verificador = double.Parse(Console.ReadLine());

            if (verificador < 0) 
            {
                double B = verificador;
                Console.WriteLine($"Número negativo armazenado na variável B.");
            }
            else
            {
                double A = verificador;
                Console.WriteLine("Número positivo armazenado na variável A.");
            }
            Console.ReadKey();
        }
    }
}
