using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade048
    {
        public void Atividade48()
        {
            Console.WriteLine("PROGRAMA AGÊNCIA DE MODELO");
            
            string[] nomes = new string[20];
            int[] idades = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Digite o nome da candidata {i + 1}: ");
                nomes[i] = Console.ReadLine();

                while (true)
                {
                    Console.Write($"Digite a idade da candidata {i + 1}: ");

                    if (int.TryParse(Console.ReadLine(), out int idade) && idade > 0)
                    {
                        idades[i] = idade;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Tente novamente.");
                    }
                }
            }
            string[] candidatosEntre18e20 = new string[20];
            int contador = 0;

            for (int i = 0; i < 20; i++)
            {
                if (idades[i] >= 18 && idades[i] <= 20)
                {
                    candidatosEntre18e20[contador] = nomes[i];
                    contador++;
                }
            }
            Console.WriteLine("Essas são as candidatas aptas:");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(candidatosEntre18e20[i]);
            }
        }
    }
}
