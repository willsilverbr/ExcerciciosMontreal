using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaRepeticao
{
    class Matematica
    {
        public static  int Exponenciacao(int Base, int Exponente)
        {
            int resultado = Base;
            if (Exponente == 1)
            {
                resultado = Base;
            }
            else

            
            for (int i = 1; i <Exponente; i ++ )
            {
                resultado = resultado * Base;  
              
            }
            return resultado;
        }
    }
}
