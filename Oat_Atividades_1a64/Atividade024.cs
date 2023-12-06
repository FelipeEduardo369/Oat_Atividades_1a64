using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade024
    {
        public void Atividade24()
        {
           
            int select = 0;
            while (select != 4) {
                Console.Clear();
                Console.WriteLine("PROGRAMA MENU VERIFICAÇÃO");
                Console.WriteLine("Informe o primeiro valor:");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o segundo valor:");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe oque deseja realizar digitando o respectivo número:\n" +
                  "1 = Verificar se um dos números é ou não múltiplo do outro\n" +
                  "2 = verificar se os dois números digitados são pares\n" +
                  "3 = Verificar se a média dos dois números é maior ou igual a sete\n" +
                  "4 = Sair");
                select = int.Parse(Console.ReadLine());
               
                if (select > 0 & select < 4) {

                    bool resultado = true;
                    switch (select) {
                        case 1:
                            {
                                multiplo(ref num1, ref num2, ref resultado);
                                Console.WriteLine($"São múltiplos? R = {resultado}");
                                break;

                            }
                        case 2:
                            {
                                par(ref num1, ref num2, ref resultado);
                                Console.WriteLine($"Os dois números são par? R = {resultado}");
                                break;
                            }
                        case 3:
                            {

                                media(ref num1, ref num2, ref resultado);
                                Console.WriteLine($"A média dos dois números é maior ou igual a 7? R = {resultado}");
                                break;
                            }
                    }
                    Console.ReadKey();
                } 
            }

            
        }
        static void multiplo(ref double a, ref double b, ref bool result) {
            if (a % b == 0 || b % a == 0)
            {
                result = true;
            }
            else { result = false; }
                }
        static void par(ref double a, ref double b, ref bool result)
        {
            if (a % 2 == 0 & b % 2 == 0)
            {
                result = true;
            }
            else { result = false; }
        }
        static void media(ref double a, ref double b, ref bool result)
        {
            if ((a + b)/2 >= 7 )
            {
                result = true;
            }
            else { result = false; }
        }
       

    }
}
