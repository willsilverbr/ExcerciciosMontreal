using System;

namespace Excercicio._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escreva um programa que receba 4 números e apresente a soma dos números pares
            // e depois dos números impares.

            int pares=0, impares=0, num, resultado;
            
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Digite o "+i+"º numeros Pares: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num%2 == 0)
                {
                    pares += num;
                 
                }
                else if (num %2 !=0)
                {
                    Console.WriteLine("Você digitou um nomero que não é par");
                    break; 
                }

            }
            Console.WriteLine("A soma dos numeros pares é: " + pares);

            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("\nDigite o "+i+"º números IMPARES: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 != 0)
                {
                    impares += num;
                   
                }
                else if (num % 2 == 0)
                {
                    Console.WriteLine("Você digitou um número que não é Impar");
                    break;
                }

            }
           
            Console.WriteLine("A soma dos numeros impares é: " + impares);

        }
    }
}
