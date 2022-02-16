using System;

namespace Exercercicio._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que gera e escreve os números ímpares dos números
            //lidos entre 0 e 200.
            //Preciso verficar se deve-se capturar os dados do usuário

            for (int i = 0; i <= 200; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }


            }
        }
    }
}
