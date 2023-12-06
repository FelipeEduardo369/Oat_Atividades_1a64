using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade015
    {
        public void Atividade15()
        {
            Console.WriteLine("PROGRAMA MÉDIA NOTA");
            Console.WriteLine("Informe a primeira nota:");
            double nota1 = double.Parse(Console.ReadLine());
            while (nota1 > 10 || nota1 < 0)
            {
                Console.WriteLine("Nota inválida, possível apenas de 0 a 10, digite novamente:");
                nota1 = double.Parse(Console.ReadLine());

            }
            Console.WriteLine("Informe a segunda nota:");
            double nota2 = double.Parse(Console.ReadLine());
            while (nota2 > 10 || nota2 < 0)
            {
                Console.WriteLine("Nota inválida, possível apenas de 0 a 10, digite novamente:");
                nota2 = double.Parse(Console.ReadLine());

            }
            Console.WriteLine("informe a terceira nota:");
            double nota3 = double.Parse(Console.ReadLine());
            while (nota3 > 10 || nota3 < 0)
            {
                Console.WriteLine("Nota inválida, possível apenas de 0 a 10, digite novamente:");
                nota3 = double.Parse(Console.ReadLine());

            }
            Console.WriteLine("Informe a quarta nota:");
            double nota4 = double.Parse(Console.ReadLine());
            while (nota4 > 10 || nota4 < 0)
            {
                Console.WriteLine("Nota inválida, possível apenas de 0 a 10, digite novamente:");
                nota4 = double.Parse(Console.ReadLine());

            }


            double resultado = 0;

            media(ref nota1, ref nota2,ref nota3, ref nota4, ref resultado );

           if (resultado >= 7)
            {
                Console.WriteLine($"Média igual a {resultado}, Você foi aprovado!");
            }
           else
            {
                Console.WriteLine($"Você está reprovado no momento com a nota {resultado}, informe a nota da recuperação:");
                double recuperacao = double.Parse(Console.ReadLine());
                while(recuperacao <0 || recuperacao > 4)
                {

                    Console.WriteLine("Nota inválida, possível apenas de 0 a 4, digite novamente:");
                    recuperacao = double.Parse(Console.ReadLine());
                }
                resultado = resultado + recuperacao;
                
                if (resultado<7) {
                    Console.WriteLine($"Você foi definitivamente reprovado com a nota {resultado}.");
                }
                else
                {
                    Console.WriteLine($"Média igual a {resultado}, Você foi aprovado!");

                }
            }

           Console.ReadKey();
        }
        

        static void media(ref double a, ref double b, ref double c, ref double d, ref double resultado)
        {
            resultado = (a + b + c + d)/4;

        }
    }
}
