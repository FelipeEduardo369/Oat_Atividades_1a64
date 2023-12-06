using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade045
    {
        public void Atividade45()
        {
            Console.WriteLine("IMPRESSAO NA ORDEM REVERSA");
            Console.WriteLine("Informe 5 números inteiros.");
            int[] numeros = new int[5];
            int contador = 0;
            while (contador < 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Informe o valor de posição {i + 1}:");
                    numeros[i] = int.Parse(Console.ReadLine());
                    contador++;
                }
            }
            Array.Reverse(numeros);
            Console.WriteLine("O números na ordem reversa são:");
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }


        }
    }
}
