using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade001
    {
        public void Atividade01()
        {
            Console.WriteLine("PROGRAMA ESTOQUE MÉDIO");
            Console.WriteLine("");
            Console.WriteLine("Informe a quantidade máxima da peça:");
            int Qmax = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade mínima da peça");
            int Qmin = int.Parse(Console.ReadLine());

            int resultado = (Qmax + Qmin) / 2;
            Console.WriteLine($"O estoque médio é: {resultado}");

            Console.ReadKey();
        }
    }
}
