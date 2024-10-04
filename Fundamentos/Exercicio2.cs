using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Exercicio2
    {
        public static void Executar()
        {
            double nota1, nota2;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            double MEDIA = (nota1 + nota2) / 2;

            Console.WriteLine($"O valor da média é: {MEDIA:F1}");
        }
    }
}
