using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_Target
{
    public class Exercicios
    {
        public void Exercicio1()
        {
            string enunciado = "Exercício 1 : Ao final do processamento, qual será o valor da variável SOMA?";

            int INDICE = 13, SOMA = 0, K = 0;
            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;

            }
            Console.WriteLine(enunciado);
            Console.WriteLine($"A soma final foi : {SOMA}");
            
        }

        public void Exercicio2() 
        {
            int numero = 0;
            Console.WriteLine("Digite um número para que este seja identificado na sequencia de Fibonacci:");
            string entrada = Console.ReadLine();
            try
            {
                numero = int.Parse(entrada);
            }
            catch (Exception)
            {
                Console.WriteLine("Você deve digitar um número!");
                throw;
            }

            List<int> listaFibonacci = new List<int>();
            int soma = 0;
            int proximonumero = 1;
            for (int i = 0; i < numero; i++)
            {
                listaFibonacci[i] = soma;
                proximonumero += soma ;
                soma = proximonumero; 
            }
            bool numeroFibonacci = false;
            Console.WriteLine("Lista gerada :");
            foreach (int lista in listaFibonacci) 
            {
                Console.WriteLine(lista.ToString());
                if (lista == numero)
                {
                    numeroFibonacci = true;
                }
            }
            Console.WriteLine($"O numero {numero} {(numeroFibonacci ? "é" : "não é")} um numero de Fibonacci");


        }
        public void Exercicio3()
        {
            Console.WriteLine("Descubra a lógica e complete o próximo elemento:");
            Console.WriteLine("a) : 1 , 3 , 5 , 7 , ____ : A resposta é 9 (incrementos de 2 em 2)");
            Console.WriteLine("b) : 2 , 4 , 8 , 16 , 32 , 64 , ____ : A resposta é 128 (multiplicar o resultado anterior por 2)");
            Console.WriteLine("c) : 0 , 1 , 4 , 9 , 16 , 25 , 36 , ____ : A resposta é 49 (a próxima diferença entre os numeros aumenta de 2 em 2)");
            Console.WriteLine("d) : 4 , 16 , 36 , 64 , ____ : A resposta é 100 (a raiz quadrada dos números é uma sequência de numeros pares)");
            Console.WriteLine("e) : 1 , 1 , 2 , 3 , 5 , 8 , ____ : A resposta é 13 (somar a resposta com o numero anterior)");
            Console.WriteLine("f) : 2 , 10 , 12 , 16 , 17 , 18 , 19 , : A resposta é 200 (todos os numeros começam com a letra D)");
            Console.WriteLine("Pressione alguma tecla para continuar...");
            Console.ReadLine();
        }
    }
}
