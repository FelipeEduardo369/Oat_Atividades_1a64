using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade055
    {
        public void Atividade55()
        {
            Console.WriteLine("PROGRAMA REMOVENDO ESPAÇOS");
            Console.Write("Digite uma frase de até 50 caracteres: ");
            string frase = Console.ReadLine();
            while (frase.Length > 50)
            {
                Console.WriteLine("A frase digitada tem mais de 50 caracteres. Tente novamente.");
                frase = Console.ReadLine();
            }            
            int QEspacos = 0;
            foreach (char caractere in frase)
            { 
                if (caractere == ' ')
                {
                    QEspacos++;
                }
            }
            string SemEspacos = RemoverEspacos(frase);
            Console.WriteLine($"A frase sem espaços = {SemEspacos}\n" +
                $"Quantidade de espaços na frase: {QEspacos}");
            
        }

        static string RemoverEspacos(string frase)
        {
            return frase.Replace(" ", "");
        }

    }
 
}
