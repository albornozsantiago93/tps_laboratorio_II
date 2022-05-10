using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public static class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            char retorno = '+';

            if(operador == '-' | operador == '/' | operador == '*')
            {
                retorno = operador;
            }
            return retorno;
        }

        public static double Operar(Operando numero1, Operando numero2, char operador)
        {
            double retorno=0;

            char operar = ValidarOperador(operador);

            switch(operar)
            {
                case '+':
                    retorno = numero1 + numero2;
                    break;

                case '-':
                    retorno = numero1 - numero2;
                    break;

                case '*':
                    retorno = numero1 * numero2;
                    break;

                case '/':
                    retorno = numero1 / numero2;                   
                    break;
            }
            return retorno;
        }
    }
}
