using System;
using System.ComponentModel;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, Mundão!! Qual Qual o teu nome? ");
            string? nome = Console.ReadLine();
            Console.Write("Hello, " + nome);

            Console.Write("Qual sua necessidade hoje: (+, -, * ou /) ?");
            char operacao = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine("Qual o primeiro numero que voce pretende usar?");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("E o segundo numero que voce pretende usar?");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;
            bool operacaoValida = true;

            switch (operacao)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                    {
                        Console.WriteLine("Erro: Não é possível dividir por zero.");
                        operacaoValida = false;
                    }
                    break;
                default:
                    Console.WriteLine("Erro: Operação inválida!");
                    operacaoValida = false;
                    break;
            }


            Console.WriteLine($"Voce escolheu os numero {operacao}, {num1} e {num2}.");
            if (operacaoValida)
            {

                Console.WriteLine($"O resultado da sua operacao é: {resultado}");
            }
        }
    }
}