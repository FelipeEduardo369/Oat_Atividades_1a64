using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade053
    {
        public void Atividade53()
        {
            Console.WriteLine("PROGRAMA MELHOR VOLTA F1");

            double[] temposVoltas = new double[10];
            Console.WriteLine("Digite os tempos de cada volta em segundos:");

            for (int i = 0; i < temposVoltas.Length; i++)
            {
                Console.Write($"Tempo da volta {i + 1}: ");

                temposVoltas[i] = double.Parse(Console.ReadLine());
            }

            if (temposVoltas.Length == 0)
            {
                Console.WriteLine("Nenhuma volta registrada.");
                return;
            }

            double melhorVolta = temposVoltas[0];
            int numeroMelhorVolta = 1;
            double somaTempos = temposVoltas[0];

            for (int i = 1; i < temposVoltas.Length; i++)
            {
                if (temposVoltas[i] < melhorVolta)
                {
                    melhorVolta = temposVoltas[i];
                    numeroMelhorVolta = i + 1;
                }

                somaTempos += temposVoltas[i];
            }
            double mediaTempos = somaTempos / temposVoltas.Length;

            Console.WriteLine($"Melhor volta: {melhorVolta} segundos (Volta {numeroMelhorVolta})");
            Console.WriteLine($"Tempo médio das voltas: {mediaTempos} segundos");
        }
    }
}
