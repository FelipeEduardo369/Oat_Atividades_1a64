using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade060
    {
        public void Atividade60()
        {
            Console.WriteLine("PROGRAMA INFORMAR QUADRANTE");
            {
                Console.Write("Digite o valor do quadrante x: ");
                double x = double.Parse(Console.ReadLine());

                Console.Write("Digite o valor do quadrante y: ");
                double y = double.Parse((Console.ReadLine()));

                int quadrante = Quadrante(x, y);
                Console.WriteLine($"O ponto ({x}, {y}) está no quadrante {quadrante}.");
            }

          
        }
        static int Quadrante(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x > 0 && y < 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else if (x < 0 && y > 0)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }
    }
}
