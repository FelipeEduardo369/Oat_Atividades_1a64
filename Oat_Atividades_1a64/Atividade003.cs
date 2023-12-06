using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade003
    {
        public void Atividade03()
        {
            Console.WriteLine("PROGRAMA CÁLCULO DE COMISSÃO");
            Console.WriteLine("Informe seu número de identificação:");
            int identificacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o código da peça vendida:");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o preço unitário da peça:");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número de peças vendidas");
            double quantidade = double.Parse(Console.ReadLine());

            double resultado =  (preco * quantidade *5) / 100;

            Console.WriteLine($"Funcionário identificado {identificacao}\n" +
                $"Pela venda produto código {codigo}, com preço unitário R$ {preco},\n" +
                $"faturou R$ {resultado} com a venda de {quantidade} peça(s).");

            Console.ReadKey();

        }
    }
}
