using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade041
    {
        public void Atividade41()
        {
            Console.WriteLine("PROGRAMA CATEGORIA NADADOR");
            Console.WriteLine("Informe a idade do nadador:");
            int idade = int.Parse(Console.ReadLine());
            
            if (idade >= 5 & idade <= 7)
            {
                Console.WriteLine("Pertence a categoria infantil A.");
            }
           else if (idade >= 8 & idade <= 11)
            {
                Console.WriteLine("Pertence a categoria infantil B.");
            }
            else if (idade >= 12 & idade <= 13)
            {
                Console.WriteLine("Pertence a categoria juvenil A.");
            }
            else if (idade >= 14 & idade <= 17)
            {
                Console.WriteLine("Pertence a categoria juvenil B.");
            }
            else if (idade >= 18)
            {
                Console.WriteLine("Pertence a categoria Adulto.");
            }
            else
            {
                Console.WriteLine("Não pertence a nenhuma categoria.");
            }


            Console.ReadKey();

        }
    }
}
