using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade019
    {
        public void Atividade19()
        {
            Console.WriteLine("PROGRAMA TIPO DE TRIÂNGULO");
            Console.WriteLine("Informe o tamanho do lado A");
            double ladoA = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o tamanho do lado B");
            double ladoB = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o tamanho do lado C");
            double ladoC = double.Parse(Console.ReadLine());
            
           if (ladoA + ladoB > ladoC & ladoB + ladoC > ladoA & ladoC +ladoA > ladoB)
            {
                if (ladoA == ladoB & ladoB == ladoC) {
                    Console.WriteLine("Características de um triângulo equilátero.");
                }
                else if (ladoA == ladoB ||  ladoA == ladoC || ladoB == ladoC) {
                    Console.WriteLine("Características de um triângulo isósceles.");
                }
                else
                {
                    Console.WriteLine("Características de um triângulo escaleno.");
                }
            }
           else
            {
                Console.WriteLine("Não são características de um triângulo.");
            }
           Console.ReadKey();   


        }
    }
}
