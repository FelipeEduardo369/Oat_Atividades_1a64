using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade044
    {
        public void Atividade44()
        {
            int select = 0;
            string opcao = "s";
            while (opcao == "s" || opcao == "S")
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA MENU GRAUS E PESO IDEAL");

                Console.WriteLine("Escolha qual programa deseja executar:\n" +
                    "1 = Conversão de graus Celsius em graus fahreinheit\n" +
                    "2 = Conversão de graus fahrenheit em graus celsius\n" +
                    "3 = Peso ideal do homem\n" +
                    "4 = Peso ideal da mulher");
                select = int.Parse(Console.ReadLine());
                while (select <= 0 || select > 4)
                {
                    Console.WriteLine("Opção inválida, digite novamente:");
                    select = int.Parse(Console.ReadLine());
                }

                switch(select) 
                {
                    case 1:
                {
                    Console.WriteLine("Informe a temperatura em graus celsius:");
                    double celsius = double.Parse(Console.ReadLine());

                    double fahrenheit = (9 * celsius + 160) / 5;

                    Console.WriteLine($"{celsius} graus celsius é igual a {fahrenheit} em graus fahrenheit");
                    Console.ReadKey();
                    break;
                }
                    case 2:
                        {
                            Console.WriteLine("Informe a temperatura em graus fahrenheit:");
                            double fahrenheit = double.Parse(Console.ReadLine());
                            double celsius = (fahrenheit - 32) * 5 / 9;

                            Console.WriteLine($"{fahrenheit} graus fahrenheit é igual a {celsius} graus celsius.");
                            Console.ReadKey();
                            break;
                        }
                
                    case 3:
                        {
                            Console.WriteLine("Informe sua altura em centímetros");
                            double altura = double.Parse(Console.ReadLine());
                            altura = altura / 100;
                            double resultado = (72.7 * altura) - 58;
                            Console.WriteLine($"Seu peso ideal é: {resultado} kg");
                            break;
                        }
                    case 4:
                        {
                        Console.WriteLine("Informe sua altura em centímetros");
                        double altura = double.Parse(Console.ReadLine());
                        altura = altura / 100;

                        double resultado = (62.1 * altura) - 44.7;
                        Console.WriteLine($"Seu peso ideal é: {resultado} kg");
                        break;
                        }
                
                }
                Console.WriteLine("Digite S para voltar ao menu desta atividade, quaalquer outra coisa para sair:");
                opcao = Console.ReadLine();

            }
        }
    }
}
