using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade004
    {
        public void Atividade04()
        {
            Console.WriteLine("PROGRAMA SOMA E MULTIPLICAÇÃO DE VALORES INTEIROS");
            Console.WriteLine("Informe o valor A:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor B:");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor C:");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor D:");
            int D = int.Parse(Console.ReadLine());

            int res1 = A + B;
            int res2 = A * B;
            int res3 = A + C;
            int res4 = A * C;
            int res5 = A + D;
            int res6 = A * D;
            int res7 = B + C;
            int res8 = B * C;
            int res9 = B + D;
            int res10 = B * D;
            int res11 = C + D;
            int res12 = C * D;

            Console.WriteLine($"{A} + {B} = {res1}\n" +
                $"{A} X {B} = {res2}\n" +
                $"{A} + {C} = {res3}\n" +
                $"{A} X {C} = {res4}\n" +
                $"{A} + {D} = {res5}\n" +
                $"{A} X {D} = {res6}\n" +
                $"{B} + {C} = {res7}\n" +
                $"{B} X {C} = {res8}\n" +
                $"{B} + {D} = {res9}\n" +
                $"{B} X {D} = {res10}\n" +
                $"{C} + {D} = {res11}\n" +
                $"{C} X {D} = {res12}");

            Console.ReadKey();
        }
    }
}
