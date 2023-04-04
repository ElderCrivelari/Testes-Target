using System;

namespace Testes_Target
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Exercicios _exercicio = new Exercicios();

            bool continuarExecutando = true;
            while (continuarExecutando)
            {
                Console.WriteLine("Bem vindo ao App TesteTarget!");
                Console.WriteLine("-----------------------------");

                Console.WriteLine("Para continuar, digite o número do exercício que deseja visualizar:");
                Console.WriteLine("1 - Processamento da variável SOMA");
                Console.WriteLine("2 - Fibonacci");
                Console.WriteLine("3 - Lógica dos elementos");
                Console.WriteLine("4 - Processamento da variável SOMA");
                Console.WriteLine("5 - Processamento da variável SOMA");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case ("1"):
                        _exercicio.Exercicio1();
                        break;

                    case ("2"):
                        _exercicio.Exercicio2();
                        break;
                    case ("3"):
                        _exercicio.Exercicio3();
                        break;
                }
                Console.WriteLine("Deseja continuar executando o programa? (S)im ou (N)ão?");
                string resposta = Console.ReadLine();
                if (resposta.ToUpper().Substring(0,1) != "S") 
                {
                    Console.WriteLine("Obrigado por testar! Pressione qualquer tecla para encerrar!");
                    Console.ReadLine();
                    continuarExecutando=false;
                }

            }
            
        }
    }
}
