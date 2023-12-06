using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade036
    {
        public void Atividade36()
        {
            Console.WriteLine("PROGRAMA MÉDIA, MAIOR E MENOR VALOR");
            Console.WriteLine("Informe 10 números inteiros:");
           
            
                int[] numeros = new int[10];
               
            
                for (int i = 0; i < numeros.Length; i++)
                {  
                    Console.WriteLine($"Informe o valor {i +1}:");
                    numeros[i] = int.Parse( Console.ReadLine() );
               

            }
            double total = 0;
                foreach (int num in  numeros)
            {
                total = total + num;    
            }
            double media = total / 10;
            int resultadoMaior = 0;
            int resultadoMenor = 0;
            maior(numeros,ref resultadoMaior);
            menor(numeros,ref resultadoMenor);

            Console.WriteLine($"A média dos números = {media}\n" +
                $"O maior número digitado = {resultadoMaior}\n" +
                $"O menor número digitado = {resultadoMenor}");



        }
        static void maior(int[] array,ref int maior)
        {
             maior = array[0];
            foreach (int numer in array) { 
            if (numer > maior)
                {
                    maior = numer;
                }
              
                    }
            
        }
        static void menor(int[] array,ref int menor)
        {
            menor = array[0];
            foreach (int numer in array)
            {
                if (numer < menor)
                {
                    menor = numer;
                }

            }

        }
    }

}
