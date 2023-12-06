using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade038
    {
        public void Atividade38()
        {
            string opcao = "s";
            while (opcao == "s" || opcao == "S")
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA CÁLCULO SALÁRIO");
                Console.WriteLine("Informe seu codigo:");
                int C = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe a quantidade de horas trabalhadas:");
                int N = int.Parse(Console.ReadLine());
                int salario = N * 10;
                int E = 0;
                if (N > 50)
                {
                    E = (salario - 500) * 2;
                    salario = 500;
                    Console.WriteLine($"O Salário ({salario}) junto com as horas excedentes ({E}) é igual a = {salario + E}");
                }
                else
                {
                    Console.WriteLine($"O salário deu um total de {salario}, não teve horas excedentes.");
                }
                Console.WriteLine("Digite S para refazer o programa, qualquer outra coisa para encerrar:");
                opcao = Console.ReadLine(); 

            }
        }

    }
}
