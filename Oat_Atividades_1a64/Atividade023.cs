using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade023
    {
        public void Atividade23()
        {
            Console.WriteLine("PROGRAMA CALCULADORA BETA");
            Console.WriteLine("Informe qual operação deseja realizar digitando o respectivo número:\n" +
                "1 = Adição\n" +
                "2 = Subtração\n" +
                "3 = Multiplicação\n" +
                "4 = Divisão");
           
            int select = int.Parse(Console.ReadLine());
            while(select < 1 || select > 4) {
                Console.WriteLine("Opção inválida, digite novamente:");
                select = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Informe o primeiro número:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = 0;

            switch (select)
            {
                case 1:
                    {
                        adicao(ref num1, ref num2, ref resultado);
                        Console.WriteLine($"{num1} + {num2} = {resultado}");
                        break;
                    }
                case 2:
                    {
                        subtracao(ref num1, ref num2, ref resultado);
                        Console.WriteLine($"{num1} - {num2} = {resultado}");
                        break;
                    }
                case 3:
                    {
                        multiplicacao(ref num1, ref num2, ref resultado);
                        Console.WriteLine($"{num1} X {num2} = {resultado}");
                        break;
                    }
                case 4:
                    {
                        divisao(ref num1, ref num2, ref resultado);
                        Console.WriteLine($"{num1} / {num2} = {resultado}");
                        break;
                    }
                
            }
            Console.ReadKey();      
        }

        static void adicao(ref double a, ref double b,ref double c)
        {
            c = a + b;
        }
        static void subtracao(ref double a, ref double b, ref double c)
        {
            c = a - b;
        }
        static void multiplicacao(ref double a, ref double b, ref double c)
        {
            c = a * b;
        }
        static void divisao(ref double a, ref double b, ref double c)
        {
            c = a / b;
        }
    }

}
