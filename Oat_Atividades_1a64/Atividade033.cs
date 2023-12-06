using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade033
    {
        public void Atividade33()
        {
            Console.WriteLine("PROGRAMA MÉDIA ALUNOS");
            int alunos = 0;
            double soma = 0;
            Console.WriteLine("Digite as notas dos alunos, para encerrar digite uma matrícula negativa.");
            while (true)
            {
                Console.Write("Matrícula do aluno (ou número negativo para encerrar): ");
                int matricula = int.Parse(Console.ReadLine());

                if (matricula < 0)
                {
                    break;
                }

                Console.Write("Nota do aluno: ");
                double nota = double.Parse(Console.ReadLine());
                soma += nota;
                alunos++;
            }
            if (alunos > 0)
            {
                double media = soma / alunos;
                Console.WriteLine($"A média das notas dos {alunos} alunos é: {media}");
            }
            else
            {
                Console.WriteLine("Nenhuma nota foi inserida.");
            }
        }
    }
}
