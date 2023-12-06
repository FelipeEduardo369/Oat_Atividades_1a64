using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade061
    {
        public void Atividade61()
        {
            Console.WriteLine("PROGRAMA REAJUSTE DE SALÁRIO");
            Console.WriteLine("Informe o salário:");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe se o reajuste é para mais ou para menos com 1 ou 2.\n" +
                "1 - mais\n" +
                "2 - menos ");
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a porcentagem de reajuste(somente o número):");
            double reajuste = double.Parse(Console.ReadLine());
            while (reajuste < 0)
            {
                Console.WriteLine("Informe o reajuste com números positivos, mesmo que seja para menos:");
                reajuste = double.Parse(Console.ReadLine());
            }
                
            while (opcao <= 0 || opcao >= 3)
            {
                Console.WriteLine("Opção inválida, tente novamente:");
                opcao = int.Parse(Console.ReadLine());

            }
            REAJUSTE(ref salario, ref reajuste, ref opcao);
            if (opcao == 1)
            {
                Console.WriteLine($"Reajuste para mais de {reajuste}, novo salário = {salario}.");
            }
            else
            {
                Console.WriteLine($"Reajuste para menos de $ {reajuste}, novo salário = $ {salario}.");
            }
        }

        static void REAJUSTE (ref double x,ref double y, ref int opc){
            if (opc == 1)
            {
                y = (x * y) / 100;
                x = x + y;
            }
            else
            {
                y = (x * y) / 100;
                x = x - y;
            }
        }
    }
}
