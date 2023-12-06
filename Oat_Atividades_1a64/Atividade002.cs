using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade002
    {
        public void Atividade02()
        {
            Console.WriteLine("PROGRAMA DÓLAR");
            Console.WriteLine("Informe o valor do dólar atualmente:");
            double dolar = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor em dólar:");
            double valor = double.Parse(Console.ReadLine());
            double resultado = dolar * valor;
            Console.WriteLine($"O valor digitado em dólar, em real é igual a: {resultado}");

        }
    }
}
