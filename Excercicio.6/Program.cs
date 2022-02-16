using System;

namespace Excercicio._6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escreva um programa que calcule a nota média de cada aluno e a média da turma. O
             * programa deve receber o nome do aluno e a nota de cada bimestre (4 notas), ao
             * informar no nome do aluno o valor “finalizar” o programa deve realizar os cálculos da
             * média e apresentar na tela.
             */

            string nomeAluno;
            int qtdAluno = 0; 
            Boolean continuar = true;
            char letra;
            double mediaTurma = 0, mediaAluno = 0, nota; ;
            do
            {
                
                Console.WriteLine("Digite o nome do Aluno: ");
                nomeAluno = Console.ReadLine();
                qtdAluno++;
                nota = 0;

                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine("Digite a " + i + "º nota");
                    nota = Convert.ToDouble(Console.ReadLine());
                   
                    mediaAluno = mediaAluno + nota;
                     
                   
                }
                mediaAluno = mediaAluno / 4; 
                mediaTurma += mediaAluno;
                Console.WriteLine("A media do Aluno " + nomeAluno + "é :" + mediaAluno);
                mediaAluno = 0;

                Console.WriteLine("\n Deseja Finalizar? Digite S para Sim ou N para não: ");
                letra = Convert.ToChar(Console.ReadLine());
                if (letra == 's' || letra == 'S') 
                {
                    continuar = true;
                   

                }else if (letra == 'n' || letra == 'N')
                {
                    continuar = false; 
                }
                
            }
            while (continuar == true);

            mediaTurma = mediaTurma / qtdAluno;
        
            Console.WriteLine("\n A media da Turma é: " + mediaTurma.ToString("F"));
        }
    }
}
