using System;

namespace Excercicio._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que gera a tabuada do número informado pelo usuário.
            int resultado, numero, i; 
            Console.WriteLine("Digite um número (inteiro) para saber sua tabuada");
            numero = Convert.ToInt32(Console.ReadLine());
            for (i =1;  i <= 10; i++)
            {
                resultado = numero * i; 
                Console.WriteLine(numero + "x" + i + ": "+ resultado);
            }
            
        }
    }
}
