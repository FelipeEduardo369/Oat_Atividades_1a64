using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade046
    {
        public void Atividade46()
        {
            Console.WriteLine("PROGRAMA PRODUTO ESCALAR DE VETORES");
            Console.WriteLine("Preencha os elementos do primeiro vetor:");
            double [] vetor1 = new double[3];
            double[] vetor2 = new double[3];
            int contador = 0;
            while(contador < 3)
            {
                for ( int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Informe o valor da posição {i + 1}");
                   
                    vetor1[i] = double.Parse( Console.ReadLine() );
                    contador++;
                }
            }
            contador = 0;
            Console.WriteLine("Informe os elementos do segundo vetor:");
            while (contador < 3)
            {
                for (int x = 0; x < 3; x++)
                {
                    Console.WriteLine($"Informe o valor da posição {x + 1}");

                    vetor2[x] = double.Parse(Console.ReadLine());
                    contador++;
                }
            }
            double resultado = 0;  
            for (int y = 0; y < 3; y++)
            {
                resultado = resultado + vetor1[y] * vetor2[y];
            }
            Console.WriteLine($"O produto escalar é igual a = {resultado}");

        }
    }
}
