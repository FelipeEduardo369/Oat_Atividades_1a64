using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade059
    {
        public void Atividade59()
        {
            Console.WriteLine("PROGRAMA DISTÂNCIA ENTRE ALFABETO");
            char primeiroCaractere, segundoCaractere;
            while (true)
            {
                Console.Write("Digite o primeiro caractere (A-Z): ");
                char.TryParse(Console.ReadLine().ToUpper(), out primeiroCaractere);
                if (primeiroCaractere >= 'A' && primeiroCaractere <= 'Z')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida, digite uma letra entre A e Z.");
                }
            }
            while (true)
            {
                Console.Write("Digite o segundo caractere (A-Z e maior que o primeiro): ");
                char.TryParse(Console.ReadLine().ToUpper(), out segundoCaractere);

                if (segundoCaractere >= 'A' && segundoCaractere <= 'Z' && segundoCaractere > primeiroCaractere)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Letra inválida, digite uma letra entre A e Z e maior que o primeiro.");
                }
            }
            int distancia = segundoCaractere - primeiroCaractere;
            Console.WriteLine($"A distância entre {primeiroCaractere} e {segundoCaractere} é de {distancia} caractere(s).");
        }
    }
}
