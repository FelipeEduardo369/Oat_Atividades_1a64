using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade034
    {
        public void Atividade34()
        {
            Console.WriteLine("PROGRAMA NUMERO MAIOR E MENOR DIGITADO");
            int numero = 0; 
            int maior = int.MinValue;
            int menor = int.MaxValue;

            Console.WriteLine("Digite números positivos. Para encerrar, digite um número negativo.");
            do
            {
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine());
                if (numero >= 0)
                {
                    if (numero > maior)
                    {
                        maior = numero;
                    }
                    if (numero < menor)
                    {
                        menor = numero;
                    }
                    
                }

            } while (numero >= 0);

                Console.WriteLine($"Maior número = {maior}");
                Console.WriteLine($"Menor número = {menor}");
           
        }
    }
}

