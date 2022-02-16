using System;

namespace Excercicio._10
{
    class Program
    {
        static void Main(string[] args)
        { //Voltar para terminar

            /*
             * Faça um programa que receba o salário e calcule o imposto de renda devido
             * para cada salário informado, se for informado 0 feche o programa. 
             * Use a tabela:
             */

            double salarioBruto, imposto, salarioLiquido, desconto;
            bool continuar = true;
            int zero;
            char letra;

            do
            {
                Console.WriteLine("Informe o valor do seu salario: ");
                salarioBruto = Convert.ToDouble(Console.ReadLine());
                salarioBruto.ToString("C");
                if (salarioBruto <= 1903.98 )
                {
                    Console.WriteLine("Não paga imposto, salario:" + salarioBruto.ToString("C"));

                    Console.WriteLine("\n Para Fechar o programa digite 0 e 'S' ou 'S' para continuar");
                    letra = Convert.ToChar(Console.ReadLine());

                    if (letra == 's' || letra == 'S')
                    {
                        continuar = true;

                    }
                    else if (letra == 'n' || letra == 'N')
                    {
                        continuar = false;
                    }
                }
                else if (salarioBruto >= 1903.98 && salarioBruto <= 2826.65)
                {
                    imposto = 7.5;
                    desconto = salarioBruto * imposto / 100;

                    salarioLiquido = salarioBruto - desconto;

                    Console.WriteLine("Seu imposto é de " + Convert.ToDecimal(desconto).ToString("f"));
                    Console.WriteLine("Seu imposto é de : {0} ", desconto.ToString("C"));
                    Console.WriteLine("O salario liquido é de " + salarioLiquido.ToString("F"));

                    Console.WriteLine("\n Para Fechar o programa digite 0 e 'S' ou 'S' para continuar");
                    letra = Convert.ToChar(Console.ReadLine());

                    if (letra == 's' || letra == 'S')
                    {
                        continuar = true;

                    }
                    else if (letra == 'n' || letra == 'N')
                    {
                        continuar = false;
                    }

                }
                else if (salarioBruto >= 2826.66 && salarioBruto <= 3751.05)
                {
                    imposto = 15;
                    desconto = salarioBruto * imposto / 100;

                    salarioLiquido = salarioBruto - desconto;

                    
                    Console.WriteLine("Seu imposto é de : {0} ", desconto.ToString("C"));
                    Console.WriteLine("O salario liquido é de " + salarioLiquido.ToString("F"));

                    Console.WriteLine("\n Para Fechar o programa digite 'N' e 'S' ou 'S' para continuar");
                    letra = Convert.ToChar(Console.ReadLine());

                    if (letra == 's' || letra == 'S')
                    {
                        continuar = true;

                    }
                    else if (letra == 'n' || letra == 'N')
                    {
                        continuar = false;
                    }

                }
                else if (salarioBruto >= 3751.06 && salarioBruto <= 4664.68)
                {
                    imposto = 22.5;
                    desconto = salarioBruto * imposto / 100;

                    salarioLiquido = salarioBruto - desconto;


                    Console.WriteLine("Seu imposto é de : {0} ", desconto.ToString("C"));
                    Console.WriteLine("O salario liquido é de " + salarioLiquido.ToString("F"));

                    Console.WriteLine("\n Para Fechar o programa digite 'n' e 'S' ou 'S' para continuar");
                    letra = Convert.ToChar(Console.ReadLine());

                    if (letra == 's' || letra == 'S')
                    {
                        continuar = true;

                    }
                    else if (letra == 'n' || letra == 'N')
                    {
                        continuar = false;
                    }

                }
                else if (salarioBruto >= 4664.68)
                {
                    imposto = 27.5;
                    desconto = salarioBruto * imposto / 100;

                    salarioLiquido = salarioBruto - desconto;


                    Console.WriteLine("Seu imposto é de : {0} ", desconto.ToString("C"));
                    Console.WriteLine("O salario liquido é de " + salarioLiquido.ToString("F"));

                    Console.WriteLine("\n Para Fechar o programa digite 'n' e 'S' ou 'S' para continuar");
                    letra = Convert.ToChar(Console.ReadLine());

                    if (letra == 's' || letra == 'S')
                    {
                        continuar = true;

                    }
                    else if (letra == 'n' || letra == 'N')
                    {
                        continuar = false;
                    }

                }




            } while (continuar == true);
        }
    }
}
