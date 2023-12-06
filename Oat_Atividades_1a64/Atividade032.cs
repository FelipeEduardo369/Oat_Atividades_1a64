using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade032
    {
        public void Atividade32()
        {
            Console.WriteLine("PROGRAMA SOMA DOS QUADRADOS IMPARES");
            Console.WriteLine("Informe um número *maior que 0 e menor que 10*:");
            int numero = int.Parse(Console.ReadLine());
            while(numero <=0 ||  numero >= 10)
            {
                Console.WriteLine("Número inválido, digite novamente:");
                numero = int.Parse(Console.ReadLine());
            }
            int guardar = numero;
            int soma = 0;
            int contador = 0;

            while (contador < 20)
            {
                if (numero % 2 != 0)
                {
                    soma += numero * numero;
                    contador++;
                }
                numero++;
            }
            Console.WriteLine($"A soma dos quadrados dos próximos 20 números ímpares a partir de {guardar} é igual a {soma}.");

        }
    }
}
