using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade056
    {
        public void Atividade56()
        {
            Console.WriteLine("QUANTIDADE NÚMEROS PARES E PRIMOS");
            int[] numeros = new int[50];
            Console.WriteLine("Informe 50 números inteiros:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Digite o valor para da posição {i + 1}: ");
                numeros[i] = Inteiro();
            }
            int Pares = 0;
            int Primos = 0;

            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    Pares++;
                }
                if (Primo(numero))
                {
                    Primos++;
                }
            }

            Console.WriteLine($"\nQuantidade de números pares: {Pares}");
            Console.WriteLine($"Quantidade de números primos: {Primos}");
        }
        static int Inteiro()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    return valor;
                }
                else
                {
                    Console.WriteLine("Número não inteiro, digite novamente");
                }
            }
        }

        static bool Primo(int numero)
        {
            if (numero < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
    
}
