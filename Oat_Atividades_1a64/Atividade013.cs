using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade013
    {
        public void Atividade13()
        {
            Console.WriteLine("PROGRAMA ORDEM DECRESCENTE");
            Console.WriteLine("Informe primeiro valor:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o terceiro valor: ");
            int num3 = int.Parse(Console.ReadLine());


            trocar(ref num1, ref num2,ref num3) ;

            Console.WriteLine($"Os números em ordem decrescente são: {num1}, {num2}, {num3}");
            


            Console.ReadKey();


        }
        static void trocar( ref int a, ref int b, ref int c)
        {
            if (a < b)
                troca(ref a, ref b);

            if (a < c)
                troca(ref a,ref c);

            if (b < c)
                troca(ref b,ref c);
        }
        static void troca(ref int x,ref int y)
        {
            int trocador = x;
            x = y;
            y = trocador;
        }


    }

      
}
    

