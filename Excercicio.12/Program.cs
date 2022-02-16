using System;

namespace Excercicio._12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *   Faça um programa que determine o maior e o menor entre os números lidos. A
                 condição de parada é a entrada de um valor 0
             */
            int condicao = 1, maior, menor, numeroAtual;

            Console.WriteLine("Digite um numero");
            maior = Convert.ToInt32(Console.ReadLine());
            menor = maior;

            do
            {
                Console.WriteLine("Digite um numero");
                numeroAtual = Convert.ToInt32(Console.ReadLine());
                if (numeroAtual>maior)
                {
                    maior = numeroAtual;
                }
                if (numeroAtual < menor && numeroAtual != 0)
                {
                    menor = numeroAtual;
                }


            } while (numeroAtual!=0);

            Console.WriteLine("O Meior numero é: " + maior);
            Console.WriteLine("O Menor numero é: " + menor);
        }
    }
}
