using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividades_1a64
{
    internal class Atividade018
    {
        public void Atividade18()
        {   
            Console.WriteLine("PROGRAMA DESCUBRA CÓDIGO DE 1 DÍGITO");
            Console.WriteLine("Informe o código:");
            int codigo = int.Parse(Console.ReadLine());
            while (codigo <= 0 || codigo >= 4 )
            {
                Console.WriteLine("Código incorreto, tente novamente:");
               codigo = (int.Parse(Console.ReadLine()));
            }
            switch (codigo)
            {
                case 1:
                    {
                        Console.WriteLine("Código 'um' digitado");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Código 'dois' digitado");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Código 'três' digitado");
                        break;
                    }
            }
            Console.ReadKey();


        }
    }
}
