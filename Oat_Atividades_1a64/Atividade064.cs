using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade064
    {
        public void Atividade64()
        {

                Console.WriteLine("PROGRAMA OPÇÃO VETOR");
                Console.WriteLine("Escolha a opção desejada:\n" +
                    "1 = Carregar Vetor (padrão, deve ser carregado para que as outras opções funcionem)\n" +
                    "2 = Listar Vetor\n" +
                    "3 = Exibir apenas os números pares do vetor\n" +
                    "4 = Exibir apenas os números ímpares do vetor\n" +
                    "5 = Exibir a quantidade de números pares que existem nas posições ímpares do vetor\n" +
                    "6 = Exibir a quantidade de números ímpares que existem nas posições pares do vetor\n" +
                    "7 = Sair");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao != 7)
                {

                    while (opcao <= 0 || opcao >= 8)
                    {
                        Console.WriteLine("Opção inválida, tente novamente:");
                        opcao = int.Parse(Console.ReadLine());
                    }
                    int[] vetor = new int[10];
                    CarregarVetor(ref vetor);

                    switch (opcao)
                    {
                        case 1:
                            {

                                CarregarVetor(ref vetor);
                                break;
                            }
                        case 2:
                            {
                                ListarVetor(ref vetor);
                                break;
                            }
                        case 3:
                            {
                                Pares(ref vetor);
                                break;
                            }
                        case 4:
                            {
                                Impares(ref vetor);
                                break;
                            }
                        case 5:
                            {
                                ParesNasPosicoesImpares(ref vetor);
                                break;
                            }
                        case 6:
                            {
                                ImparesNasPosicoesPares(ref vetor);
                                break;
                            }
                }
               
                
              }

        }
        static void CarregarVetor(ref int[] vetor)
        {
            Console.WriteLine("Digite os valores do vetor:");

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"valor {i + 1}: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void ListarVetor(ref int[] vetor)
        {
            Console.WriteLine("Valores do vetor:");

            foreach (int i in vetor)
            {
                Console.Write(i+ "\n");
            }

            Console.WriteLine();
        }
        static void Pares(ref int[] vetor)
        {
            Console.WriteLine("Números pares:");
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.Write(vetor[i] + "\n");
                }
            }
        }
        static void Impares(ref int[] vetor)
        {
            Console.WriteLine("Números ímpares:");
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    Console.Write(vetor[i] + "\n");
                }
            }
        }
        static void ParesNasPosicoesImpares(ref int[] vetor)
        {
            int contador = 0;
            for (int i = 1; i < vetor.Length; i += 2)
            {
                if (vetor[i] % 2 == 0)
                {
                    contador++;
                }
            }
            Console.WriteLine($"quantidade de números pares nas posições ímpares: {contador}");
        }
        static void ImparesNasPosicoesPares(ref int[] vetor)
        {
            int contador = 0;
            for (int i = 0; i < vetor.Length; i += 2)
            {
                if (vetor[i] % 2 != 0)
                {
                    contador++;  
                }
            }
            Console.WriteLine($"quantidade de números impares nas posições pares: {contador}");

        }
    }
}
