using System;

namespace Excercicio._7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que receba uma quantidade definida pelo usuário de números e
              pegue o maior e o menor número informado e apresente na tela.*/

            int numeroAtual, numeroMenor = 0, numeroMaior = 0, qtdNumeros;
            Console.WriteLine("Quantos numero dejesa informar? ");
            qtdNumeros = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o 1º numero: " );
            numeroAtual = Convert.ToInt32(Console.ReadLine());
            numeroMaior = numeroAtual;
            numeroMenor = numeroAtual;

            for (int i = 2; i <= qtdNumeros; i++)
            {
                Console.WriteLine("Digite o " + i + "º Número: ");
                
                numeroAtual = Convert.ToInt32(Console.ReadLine());

                if (numeroAtual > numeroMaior)
                {
                    numeroMaior = numeroAtual;
                }
                else if (numeroAtual < numeroMenor)
                {
                    numeroMenor = numeroAtual;
                }
                

               

            }
            Console.WriteLine("\n O maior numero é: " + numeroMaior + "" +
                "\n O menor numero é: " + numeroMenor);
        }
    }
}
