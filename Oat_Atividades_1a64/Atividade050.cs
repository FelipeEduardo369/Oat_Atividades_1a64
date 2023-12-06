using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade050
    {
        public void Atividade50()
        {
            Console.WriteLine("PROGRAMA TENTE A SORTE");
            Random numero = new Random();

            
            int numeroSorteado = numero.Next(101);
            int tentativas = 0;

            Console.WriteLine("Tente adivinhar o número sorteado (entre 0 e 100):");
            while (true)
            {
                Console.Write("Digite sua tentativa: ");
                if (int.TryParse(Console.ReadLine(), out int tentativa))
                {
                    tentativas++;
                    if (tentativa == numeroSorteado)
                    {
                        Console.WriteLine($"Parabéns! Você acertou o número {numeroSorteado} em {tentativas} tentativas.");
                        break;
                    }
                    else if (tentativa < numeroSorteado)
                    {
                        Console.WriteLine("O número sorteado é maior, tente novamente.");
                    }
                    else
                    {
                        Console.WriteLine("O número sorteado é menor, tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                }
            }
        }
    }
}
