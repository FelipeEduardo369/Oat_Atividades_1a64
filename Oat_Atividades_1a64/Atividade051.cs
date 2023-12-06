using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade051
    {
        public void Atividade51()
        {
            Console.WriteLine("PROGRAMA MÉDIA ALUNOS");
            
            double soma = 0;
            int AcimaDeSete = 0;
            int AcimaDeCinco = 0;

            
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Digite a nota do aluno {i} (entre 0 e 10): ");

                if (double.TryParse(Console.ReadLine(), out double nota) && nota >= 0 && nota <= 10)
                {
                    soma += nota;

                    if (nota > 7)
                    {
                        AcimaDeSete++;
                    }
                }
                else
                {
                    Console.WriteLine("Nota inválida. Por favor, digite um número entre 0 e 10.");
                    i--;
                }
                if (nota > 5)
                {
                    AcimaDeCinco++;
                }
            }

            double media = 10 > 0 ? soma / 10 : 0;

            Console.WriteLine($"A média das notas dos alunos é: {media}");

            if (AcimaDeSete > 0)
            {
                Console.WriteLine($"Número de alunos com nota acima de 7: {AcimaDeSete}");
            }
            

            if (AcimaDeCinco == 0)
            {
                Console.WriteLine("Nenhum aluno tirou nota acima de 5.");
            }
           
        }
    }
}
