using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade047
    {
        public void Atividade47()
        {
            Console.WriteLine("PROGRAMA COMPARAÇÃO COM VETOR");
            int[] vetor = new int[10];
            for (int i = 0; i < vetor.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Digite o numero de valor {i+1} ");

                    if (int.TryParse(Console.ReadLine(), out int valor) && valor > 0)
                    {
                        vetor[i] = valor;
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Número menor ou igual a 0, tente novamente.");
                    }
                }
            }
            int x;
            while (true)
            {
                Console.Write("Informe um número também maior que zero para comparação: ");
                if (int.TryParse(Console.ReadLine(), out x) && x > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(" Número menor ou igual a 0, tente novamente.");
                }
            }
            int maiores = 0;
            int menores = 0;
            int iguais = 0;

            foreach (int numero in vetor)
            {
                if (numero > x)
                {
                    maiores++;
                }
                else if (numero < x)
                {
                    menores++;
                }
                else
                {
                    iguais++;
                }
            }
            Console.WriteLine($"\nQuantidade de números maiores que {x}: {maiores}\n" +
                $"Quantidade de números menores que {x}: {menores}\n" +
                $"Quantidade de números iguais a {x}: {iguais}");
            
        }
    }
}
