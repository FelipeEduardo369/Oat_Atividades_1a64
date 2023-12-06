using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade020
    {
        public void Atividade20()
        {
            Console.WriteLine("PROGRAMA DIVISÃO E MULTIPLICAÇÃO ENTRE NÚMEROS");

            Console.WriteLine("Informe o primeiro valor:");
            int A = int.Parse(Console.ReadLine());
            while (A <= 0) {
                Console.WriteLine("Valor inválido, digite um valor maior que 0");
                 A = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Informe o segundo valor:");
            int B = int.Parse(Console.ReadLine());
            while (B <= 0)
            {
                Console.WriteLine("Valor inválido, digite um valor maior que 0");
                 B = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Informe o terceiro valor:");
            int C = int.Parse(Console.ReadLine());
            while (C <= 0)
            {
                Console.WriteLine("Valor inválido, digite um valor maior que 0");
                 C = int.Parse(Console.ReadLine());
            }

            troca(ref A, ref B, ref C);
            int resultado1 = C * A;
            double resultado2 = A / C;
            Console.WriteLine($"O menor valor ({C}), multiplicado pelo maior ({A}) é igual a {resultado1}.");
            Console.WriteLine($"O maior valor ({A}), dividido pelo menor ({C}) é igual a {resultado2}.");
            Console.ReadKey();

        }
        static void troca(ref int valorA, ref int valorB, ref int valorC)
        {
            if (valorA < valorB)
                trocar(ref valorA, ref valorB);
            if (valorA < valorC)
                trocar(ref valorA, ref valorC);

            if (valorB < valorC)
                trocar(ref valorB, ref valorC);

        }

        static void trocar(ref int a,ref int b) 
        {
            int marcador = a;
            a = b;
            b = marcador;   
        }
    }
}
