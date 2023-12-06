using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade027
    {
        public void Atividade27()
        {
            Console.Write("Informe o número para fatorear: ");
            int numero = int.Parse(Console.ReadLine());

            
            long resultado = CalcularFatorial(numero);

           
            Console.WriteLine($"O fatorial de {numero} é: {resultado}");
        }
        static long CalcularFatorial(int n)
        {
            

            if (n == 0 || n == 1)
            {
                return 1;
            }

            long resultado = 1;

            for (int i = 2; i <= n; i++)
            {
                resultado = resultado * i;
            }

            return resultado;
        }
    }
}
