using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            double nota1, nota2, nota3;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());

            double MEDIA = (nota1 + nota2 + nota3) / 3;

            if(MEDIA >= 7)
            {
                Console.WriteLine("Você não é uma pessoa leiga. Sua média é: " + MEDIA);
            }
            else
            {
                Console.WriteLine("Você é um leigo. Peça ajuda para o Pedro H.S. Sua média é: " + MEDIA);
            }
        }
    }
}
