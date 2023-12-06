using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade054
    {
        public void Atividade54()
        {
            Console.WriteLine("PROGRAMA VALORES EM COMUM");
            int[] vetorA = new int[5];
            int[] vetorB = new int[8];

            Console.WriteLine("Preencha o vetor A com 5 valores:");

            for (int i = 0; i < vetorA.Length; i++)
            {
                Console.Write($"Digite o valor para a posição {i + 1}: ");
                vetorA[i] = LerInteiro();
            }
            Console.WriteLine("\nPreencha o vetor B com 8 valores:");

            for (int i = 0; i < vetorB.Length; i++)
            {
                Console.Write($"Digite o valor para a posição {i + 1}: ");
                vetorB[i] = LerInteiro();
            }
            Console.WriteLine("Valores em comum entre os dois vetores:");

            foreach (int valorA in vetorA)
            {
                foreach (int valorB in vetorB)
                {
                    if (valorA == valorB)
                    {
                        Console.WriteLine($"{valorA}");
                        break;
                    }
                }
            }
        }
        static int LerInteiro()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    return valor;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                }
            }
        }
    }
}
