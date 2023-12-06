using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade017
    {
        public void Atividade17()
        {
            Console.WriteLine("PROGRAMA INTERVALO DE 0 A 9");
            Console.WriteLine("Informe um número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0 & numero <=9) {
                Console.WriteLine("Valor Válido");
            }
            else { Console.WriteLine("Valor inválido"); }

            Console.ReadKey();
        }
     
    }
    
}
