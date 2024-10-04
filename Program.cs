using System;
using System.Collections.Generic;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Exercício 1 - Prática", Exercicio1.Executar},
                {"Exercício 2 - Prática", Exercicio2.Executar},
                {"Exercício 3 - Prática", Exercicio3.Executar},
                {"Estrutura If - EstruturasDeControle", EstruturaIf.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}