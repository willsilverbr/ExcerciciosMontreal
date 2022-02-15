using System;

namespace EstruturaRepeticao
{
    class NumeroExpoenteMain
    {
        static void Main(string[] args)
        {
            /*
             fazer um programa que precisa fazer um calculo com um metodo estatico chamado 
            exponenciação 
            
             */
            int b, e; 
            Console.WriteLine("Digite o Valor da Base: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Valor do Expoente: ");
            e = Convert.ToInt32(Console.ReadLine());

            int resultado = Matematica.Exponenciacao(b, e);
            Console.WriteLine(b+ " Elevado a " + e + " é : " + resultado);
        }
    }
}
