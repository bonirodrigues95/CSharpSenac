using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {

        public static void Executar() {

            string nome = "Luiz";
            int idade = 21;
            string sexo = "M";
            double altura = 1.80;
            bool temCachorro = true;

            Console.WriteLine($"Olá meu nome é {nome} e eu tenho {idade} anos.");

            var time = "Cortinas";
            var posicao = 17;
            //O var interpreta a variável que você criou de acordo com o tipo dela

            //variavel do tipo real
            double raio = 4.5;

            //constante
            const double pi = 3.14;

            double area = pi * raio * raio;

            Console.WriteLine("Area total é "+area);


        }
    }
}
