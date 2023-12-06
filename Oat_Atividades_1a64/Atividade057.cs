using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade057
    {
        public void Atividade57()
        {
            Console.WriteLine("PROGRAMA IMPRESSÃO DE VOGAIS");
            Console.Write("Digite uma frase:");
            string frase = Console.ReadLine();
            Console.WriteLine("Vogais na frase:");

            foreach (char caractere in frase)
            {
                char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

                if (Array.IndexOf(vogais, caractere) != -1)
                {
                    Console.Write(caractere);
                }
            }
            Console.WriteLine("");
        }
    }
}
