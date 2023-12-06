using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade039
    {
        public void Atividade39()
        {
            string opcao = "s";
            while (opcao == "s" || opcao == "S")
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA PAR OU ÍMPAR, NEGATIVO OU POSITIVO");
                Console.WriteLine("Informe um número inteiro:");
                int numero = int.Parse(Console.ReadLine());

                if (numero < 0 & numero % 2 == 0)
                {
                    Console.WriteLine("O número digitado é par negativo");
                }
                else if (numero >= 0 & numero % 2 == 0)
                {
                    Console.WriteLine("O número digitado é par e positivo");
                }
                else if (numero > 0 & numero % 2 != 0)
                {
                    Console.WriteLine("O número digitado é ímpar e positivo");
                }
                else
                {
                    Console.WriteLine("O número é impar e negativo");
                }
                Console.WriteLine("Digite S para refazer o programa, qualquer outro número para sair:");
                opcao = Console.ReadLine();
            }
            }
    }
}
