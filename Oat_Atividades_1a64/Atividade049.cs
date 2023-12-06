using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade049
    {
        public void Atividade49()
        {
            Console.WriteLine("PROGRAMA NÚMEROS IDENTICOS NA MESMA POSIÇÃO");
            
        int[] vetor1 = new int[10];
        int[] vetor2 = new int[10];
        Console.WriteLine("Preencha o primeiro vetor:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o valor para o elemento {i + 1}: ");
                vetor1[i] = int.Parse( Console.ReadLine() );    
            
           
        }

        Console.WriteLine("Preencha os elementos do vetor 2:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o valor para o elemento {i + 1}: ");
                vetor2[i] = int.Parse(Console.ReadLine());



            }

        int resultado = 0;

        for (int i = 0; i < 10; i++)
        {
            if (vetor1[i] == vetor2[i])
            {
                resultado++;
            }
        }
        Console.WriteLine($"A quantidade de valores iguais nas mesmas posições é igual a = {resultado}");
        }
    }
}
