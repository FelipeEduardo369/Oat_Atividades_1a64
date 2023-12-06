using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade009
    {
        public void Atividade09()
        {
            Console.WriteLine("PROGRAMA DIAS NA TERRA");
            Console.WriteLine("Informe sua idade:");
            double idade = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantos meses comemorou o último aniversário:");
            double meses = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe quantos dias faltam para acabar o mês atual:");
            double dias = double.Parse(Console.ReadLine());
            double resultado = (idade * 360) + (meses * 30) + dias;

            Console.WriteLine($"Você já viveu {resultado} dias na terra!");

            Console.ReadKey();
        }
    }
}
