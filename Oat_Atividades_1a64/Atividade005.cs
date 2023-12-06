using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade005
    {
        public void Atividade05()
        {
            Console.WriteLine("PROGRAMA CÁLCULO LITROS DE COMBUSTÍVEL");
            Console.WriteLine("Quanto tempo foi gasto na viagem (EM HORAS)? ");
            double tempo = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a velocidade média percorrida?");
            double velocidade = double.Parse(Console.ReadLine());   
            double distancia = tempo * velocidade;
            double litros = distancia / 12;

            Console.WriteLine($"Velocidade média de {velocidade}\n" +
                $"Com o tempo gasto de {tempo} horas\n" +
                $"A distância percorrida foi de {distancia} KM\n" +
                $"Sendo assim, utilizando um automóvel que faz 12km por litro, foram gastos {litros} litros nesta viagem!");

            Console.ReadKey();

        }
    }
}
