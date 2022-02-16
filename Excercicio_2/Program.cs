using System;

namespace Excercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia:
            - A quantidade de números que o usuário deseja informar.
            - Leia cada número e informe a média aritmética e a soma deles
            */
            int valorDivisor;
            double soma, resultado =0;
            
            Console.WriteLine("Informe a quantidade de números que deseja calcular: ");
            valorDivisor = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= valorDivisor; i++)
            {
                Console.WriteLine("\nInforme o valor do " + i + "º número");
                soma = Convert.ToDouble(Console.ReadLine());
                resultado += soma; 
            }
            
            resultado = (resultado / valorDivisor);
            Console.WriteLine("\n A Media Aritimetica é: " + resultado.ToString("F"));

        }
    }
}
