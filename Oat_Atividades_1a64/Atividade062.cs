using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade062
    {
        public void Atividade62()
        {
            Console.WriteLine("PROGRAMA HIPOTENUSA");
            Console.WriteLine("Informe o valor da base do triângulo:");
            double Base = double.Parse(Console.ReadLine());
            while(Base <= 0)
            {
                Console.WriteLine("Valor inválido, digite um número válido:");
                Base = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Informe o valor da altura do triângulo:");
            double altura = double.Parse(Console.ReadLine());
            while (altura <= 0)
            {
                Console.WriteLine("Valor inválido, digite um número válido:");
                altura = double.Parse(Console.ReadLine());
            }
            double resultado = 0;
            HIPOTENUSA(ref Base, ref altura, ref resultado);

            Console.WriteLine($"Um triângulo com base = {Base} e altura = {altura} tem a hipotenusa = {resultado}.");

        }
        static void HIPOTENUSA(ref double x, ref double y, ref double result)
        {
            result = Math.Pow(x,2) + Math.Pow(y,2);
            result = Math.Sqrt(result);

        }
    }
}
