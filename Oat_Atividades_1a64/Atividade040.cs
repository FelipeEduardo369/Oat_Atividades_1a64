using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade040
    {
        public void Atividade40()
        {
            string opcao = "s";
            while (opcao == "s" || opcao == "S")
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA ÍNDICE DE POLUIÇÃO");
                Console.WriteLine("Informe o índice de poluição:");
                double indice = double.Parse(Console.ReadLine());
                while (indice < 0.05)
                {
                    Console.WriteLine("Indice invalido, digite novamente:");
                    indice = double.Parse(Console.ReadLine());
                }
                if (indice < 0.3)
                {
                    Console.WriteLine("O índice de poluição está aceitável");
                }
                
                else if (indice >= 0.3 & indice < 0.4){
                    Console.WriteLine("As empresas do primeiro grupo devem suspender suas atividades");


                }
                else if (indice >= 0.4 & indice < 0.5)
                {
                    Console.WriteLine("As empresas do primeiro e segundo grupo devem suspender suas atividades");
                }
                else
                {
                    Console.WriteLine("Todos os grupos de empresas devem suspender suas atividades");
                }
                Console.WriteLine("Digite s para refazer, qualquer outra coisa para encerrar:");
                opcao = Console.ReadLine(); 
            }
        }
    }
}
