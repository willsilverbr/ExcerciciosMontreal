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

            do
            {
                Console.WriteLine("Informe o valor do seu salario: ");
                salarioBruto = Convert.ToDouble(Console.ReadLine());
                //salarioBruto.ToString("C");

                if (salarioBruto>=1.90399)
                {
                    imposto = 7.5;
                    desconto = salarioBruto * imposto/100;
                  
                    salarioLiquido = salarioBruto - desconto;
                   
                    Console.WriteLine("Seu imposto é de " + Convert.ToDecimal(desconto));
                    Console.WriteLine("Seu imposto é de : {0} ", desconto );
                    Console.WriteLine("O salario liquido é de " + salarioLiquido.ToString("F"));

                }



            } while (true);
        }
    }
}
