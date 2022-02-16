using System;

namespace Excercicio._9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Faça um programa de conversão de base numérica. O programa deverá apresentar
                uma tela de entrada com as seguintes opções:
                1 – Adição
                2 – Subtração
                3 – Multiplicação
                4 – Divisão
                Informe a opção:
                A partir da opção escolhida, o programa deverá solicitar para que o usuário digite dois
                números. Em seguida, o programa deve exibir o resultado da opção indicada pelo
                usuário e perguntar ao usuário se ele deseja voltar ao menu principal. Caso a resposta
                seja “S” ou “s”, deverá voltar ao menu, caso contrário deverá encerrar o programa.
             */
            int opcao, resultado, valorA, valorB;
            bool menu = false;
            char letra;
            do
            {
                
                Console.WriteLine("Digite uma opção: " +
                              "1 – Adição" +
                              "2 – Subtração" +
                              "3 – Multiplicação" +
                              "4 – Divisão");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Você selecionou a opção de somar. " +
                                          "Por favor, Informe o primeiro valor: ");
                        valorA = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Por favor, informe o segundo Valor: ");
                        valorB = Convert.ToInt32(Console.ReadLine());
                        resultado = valorA + valorB;
                        Console.WriteLine("O Valor da sua soma é de: " + resultado);
                        Console.WriteLine("\n Deseja Voltar ao menu principal? para sim “S” ou “s”, para não “N” ou “n” \n");
                        letra = Convert.ToChar(Console.ReadLine());
                        if (letra=='s' || letra=='S')
                        {
                            menu = true;
                        }
                        else if (letra == 'N' || letra == 'n')
                        {
                            Console.WriteLine("Obrigado! Você Encerrou o programa.");
                            menu = false; 
                        }
                        resultado = 0;
                        break;


                    case 2:
                        Console.WriteLine("Você selecionou a opção de Subtração. " +
                                          "Por favor, Informe o primeiro valor: ");
                        valorA = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Por favor, informe o segundo Valor: ");
                        valorB = Convert.ToInt32(Console.ReadLine());
                        resultado = valorA - valorB;
                        Console.WriteLine("O Valor da sua soma é de: " + resultado);
                        Console.WriteLine("\n Deseja Voltar ao menu principal? para sim “S” ou “s”, para não “N” ou “n” \n");
                        letra = Convert.ToChar(Console.ReadLine());
                        if (letra == 's' || letra == 'S')
                        {
                            menu = true;
                        }
                        else if (letra == 'N' || letra == 'n')
                        {
                            Console.WriteLine("Obrigado! Você Encerrou o programa.");
                            menu = false;
                        }
                        resultado = 0;
                        break;

                    case 3:
                        Console.WriteLine("Você selecionou a opção de Multiplicação. " +
                                          "Por favor, Informe o primeiro valor: ");
                        valorA = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Por favor, informe o segundo Valor: ");
                        valorB = Convert.ToInt32(Console.ReadLine());
                        resultado = valorA * valorB;
                        Console.WriteLine("O Valor da sua Multiplicação é de: " + resultado);
                        Console.WriteLine("\n Deseja Voltar ao menu principal? para sim “S” ou “s”, para não “N” ou “n” \n");
                        letra = Convert.ToChar(Console.ReadLine());
                        if (letra == 's' || letra == 'S')
                        {
                            menu = true;
                        }
                        else if (letra == 'N' || letra == 'n')
                        {
                            Console.WriteLine("Obrigado! Você Encerrou o programa.");
                            menu = false;
                        }
                        resultado = 0;
                        break;

                    case 4:
                        Console.WriteLine("Você selecionou a opção de Divisão. " +
                                          "Por favor, Informe o primeiro valor: ");
                        valorA = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Por favor, informe o segundo Valor: ");
                        valorB = Convert.ToInt32(Console.ReadLine());
                        resultado = valorA / valorB;
                        Console.WriteLine("O Valor da sua Divisão é de: " + resultado);
                        Console.WriteLine("\n Deseja Voltar ao menu principal? para sim “S” ou “s”, para não “N” ou “n” \n");
                        letra = Convert.ToChar(Console.ReadLine());
                        if (letra == 's' || letra == 'S')
                        {
                            menu = true;
                        }
                        else if(letra == 'N' || letra == 'n')
                        {
                            Console.WriteLine("Obrigado! Você Encerrou o programa.");
                            menu = false;
                        }
                        resultado = 0;
                        break;

                }

            } while (menu == true);
            
        }
    }
}
