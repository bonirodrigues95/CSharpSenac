using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumeros
    {

        public static void Executar()
        {
            double valor = 45.2345;

            //Arredondar
            Console.WriteLine(valor.ToString("F1"));

            //Transformar em valor monetário
            Console.WriteLine(valor.ToString("C"));

            //Formatando do jeito que eu quero
            Console.WriteLine(valor.ToString("#.##"));

            //Multiplica um valor por 100 e adiciona percentual
            Console.WriteLine(valor.ToString("P"));
        }
    }
}
