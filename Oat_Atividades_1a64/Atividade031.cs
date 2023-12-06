using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade031
    {
        public void Atividade31()
        {
           Console.WriteLine("PROGRAMA PAR E ÍMPAR SOMA");
           int numero;
           int pares = 0;
           int impares = 0;

            Console.WriteLine("Digite os números desejados, para encerrar, digite um número negativo.");
            do
            {
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 0)
                {
                    if (numero % 2 == 0)
                    {
                        Console.WriteLine($"{numero} é par.");
                        pares += numero;
                    }
                    else
                    {
                        Console.WriteLine($"{numero} é ímpar.");
                        impares += numero;
                    }
                }

            } while (numero >= 0);

            Console.WriteLine($"Soma dos números pares: {pares}");
            Console.WriteLine($"Soma dos números ímpares: {impares}");
        }
    }
    }

