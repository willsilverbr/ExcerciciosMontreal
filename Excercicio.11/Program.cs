using System;
using System.Collections.Generic;

namespace Excercicio._11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Faça um programa que dada o nome e idade de um nadador, classifique-o em uma das
                seguintes categorias:
                - Infantil A = 5 a 7 anos
                - Infantil B = 8 a 11 anos
                - Juvenil A = 12 a 13 anos
                - Juvenil B = 14 a 17 anos
                - Adultos = Maiores de 18 anos
                Ao final apresente as categorias e o nome dos nadadores e idade de cada uma dentro
                das suas respectivas categorias de natação.
              */
            bool controle = true;
            int idade;
            string nome;
            char sair;
            Dictionary<string, int> infantilA = new Dictionary<string, int>();
            Dictionary<string, int> infantilB = new Dictionary<string, int>();
            Dictionary<string, int> juvenilA = new Dictionary<string, int>();
            Dictionary<string, int> juvenilB = new Dictionary<string, int>();
            Dictionary<string, int> adultos = new Dictionary<string, int>();

            do
            {
                Console.WriteLine("Digite a Idade do nadador: ");
                idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o nome do nadado");
                nome = Console.ReadLine();

                if (idade >= 5 && idade <= 7)
                {
                    infantilA.Add(nome, idade);
                }
                else if (idade > 7 && idade <= 11)
                {
                    infantilA.Add(nome, idade);
                }
                else if (idade > 11 && idade <= 13)
                {
                    infantilA.Add(nome, idade);
                }
                else if (idade > 14 && idade <= 17)
                {
                    infantilA.Add(nome, idade);
                }
                else if (idade > 7)
                {
                    infantilA.Add(nome, idade);
                }

                Console.WriteLine("Deseja Continuar um novo cadastro?? 'S' para Sim ou 'N para não: '");
                sair = Convert.ToChar(Console.ReadLine());
                if (sair == 'n' || sair == 'N')
                {
                    controle = false;
                }
                else if (sair == 'S' || sair == 's')
                {
                    controle = true;
                }



            } while (controle == true);
            //foreach (var item in infantilA)
            //{
                
            //    Console.WriteLine(infantilA[]);
            //}
        }

    }
}
