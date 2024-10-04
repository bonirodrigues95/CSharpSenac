using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class Exercicio1
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

            Console.WriteLine($"O valor da média é: {MEDIA:F2}");
           

        }
    }
}