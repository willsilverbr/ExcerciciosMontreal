using System;

namespace Excercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Faça um programa que calcule um plano de salário de um funcionário da Empresa XYZ,
                onde deve ser informado a quantidade de anos de trabalho e o salário inicial. É regra
                da empresa é aumentar o salário nos 3 primeiros anos em 50% a cada ano, nos demais
                ela aumenta em 100% a cada ano trabalhado e a cada 10 anos ela dá um bônus de
                10% de aumento..
             */
            double salarioAtual, novoSalario=0, porcentagem=0;
            int anosTrabalhados;

            Console.WriteLine("Digite o Salario Atual: ");
            salarioAtual = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe quantos anos de trabalho nessa empresa: ");
            anosTrabalhados = Convert.ToInt32(Console.ReadLine());

            if (anosTrabalhados<=3)
            {
                for (int i = 0; i <=anosTrabalhados; i++)
                {
                    novoSalario = salarioAtual;
                    porcentagem = salarioAtual*50/100;
                    salarioAtual = salarioAtual + porcentagem; 
                    Console.WriteLine("acrescimo de 50% no Salario no "+i+"º Ano de trabalho: " +novoSalario.ToString("c"));

                }
            }
            else if (anosTrabalhados > 3)
            {
                for (int i = 3; i <= anosTrabalhados; i++)
                {
                    novoSalario = salarioAtual;
                    porcentagem = salarioAtual * 50 / 100;
                    salarioAtual = salarioAtual + porcentagem;
                    

                    if (i==10 || i==20 || i==30 || i==40 || i==50)
                    {
                        novoSalario = salarioAtual;
                        porcentagem = salarioAtual * 10 / 100;
                        salarioAtual = salarioAtual + porcentagem;
                    }

                    Console.WriteLine("acrescimo de 50% no Salario no " + i + "º Ano de trabalho: " + novoSalario.ToString("c"));
                }
            }



        }
    }
}
