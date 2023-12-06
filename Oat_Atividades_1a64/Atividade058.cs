using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade058
    {
        public void Atividade58()
        {
            Console.WriteLine("PROGRAMA MEDIA E MAIOR NÚMERO");
            {
                Console.Write("Digite a quantidade de números a serem lidos: ");
                int quantidade;
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out quantidade) && quantidade > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Digite um número inteiro positivo.");
                        Console.Write("Digite a quantidade de números a serem lidos: ");
                    }
                }
                int[] numeros = new int[quantidade];
                Console.WriteLine("Digite os números:");

                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.Write($"Valor {i + 1}: ");
                    numeros[i] = Inteiro();
                }

                double media = 0;
                int soma = 0;
                int maiorValor = numeros[0];

                foreach (int numero in numeros)
                {
                    soma += numero;

                    if (numero > maiorValor)
                    {
                        maiorValor = numero;
                    }
                }

                if (numeros.Length > 0)
                {
                    media = (double)soma / numeros.Length;
                }
                Console.WriteLine($"Média dos números: {media}");
                Console.WriteLine($"Maior valor digitado: {maiorValor}");
            }
        }
        static int Inteiro()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int valor) && valor > 0)
                {
                    return valor;
                }
                else
                {
                    Console.WriteLine("Número inválido, digite um número inteiro positivo.");
                }
            }
        }
    }
}
