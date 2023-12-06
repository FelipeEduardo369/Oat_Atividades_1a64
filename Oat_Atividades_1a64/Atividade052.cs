using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade052
    {
        public void Atividade52()
        {
            Console.WriteLine("PROGRAMA NUMEROS 1,3 E 4");
            int[] vetor = new int[20];
            Console.WriteLine("Preencha o vetor com valores inteiros:");

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite o valor para a posição {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());

            }
            int Numero1 = 0;
            int Numero3 = 0;
            int Numero4 = 0;
            foreach (int numero in vetor)
            {
                if (numero == 1)
                {
                   Numero1++;
                }
                else if (numero == 3)
                {
                   Numero3++;
                }
                else if (numero == 4)
                {
                   Numero4++;
                }
            }
            Console.WriteLine($"O número 1 aparece {Numero1} vezes no vetor.");
            Console.WriteLine($"O número 3 aparece {Numero3} vezes no vetor.");
            Console.WriteLine($"O número 4 aparece {Numero4} vezes no vetor.");
        }
    }
}
