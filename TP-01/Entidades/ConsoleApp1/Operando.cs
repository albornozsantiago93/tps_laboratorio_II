using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Operando
    {
        private double numero;

        public Operando()
        {
            this.numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string numero)
        {
            this.Numero = numero;
        }

        #region Sobrecarga operadores
        public static double operator -(Operando n1, Operando n2)
        {
            return Math.Round((n1.numero - n2.numero), 4);
        }

        public static double operator +(Operando n1, Operando n2)
        {
            return Math.Round((n1.numero + n2.numero), 4);
        }

        public static double operator *(Operando n1,Operando n2)
        {
            return Math.Round((n1.numero * n2.numero), 4);
        }

        public static double operator /(Operando n1,Operando n2)
        {
            double retorno;
            if (n2.numero == 0)
            {
                retorno = double.MinValue;
            }
            else
            {
                retorno = Math.Round((n1.numero / n2.numero), 4);
            }
            return retorno;
        }

        #endregion

        /// <summary>
        /// ValidarOperando comprobará que el valor recibido sea numérico, y lo retornará en formato double. Caso contrario, retornará 0.
        /// </summary>
        /// <param name="num"></param>
        /// <returns> 0 por defecto</returns>
        private double ValidarOperando(string num)
        {
            double retorno;

            bool isNumeric = double.TryParse(num, out double numero);
            if (isNumeric)
            {
                retorno = numero;
            }
            else
            {
                retorno = 0;
            }
            return retorno;
        }
        private string Numero
        {
            set
            {                
                this.numero = ValidarOperando(value);
            }
            get
            {
                return this.numero.ToString();
            }
        }
        /// <summary>
        /// El método privado EsBinario validará que la cadena de caracteres esté compuesta SOLAMENTE por caracteres '0' o '1'.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private bool EsBinario(string binario)
        {
            bool retorno = true;

            foreach(char c in binario)
            {
                if(c != '0' && c!='1')
                {
                    retorno = false;
                }
            }

            return retorno;
        }

        /// <summary>
        /// validará que se trate de un binario y luego convertirá ese número binario a decimal, en caso de ser posible. Caso contrario retornará "Valor inválido".
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            string retorno;
            bool esBinario = this.EsBinario(binario);

            if (esBinario)
            {
                int resultado = Convert.ToInt32(binario, 2);
                resultado = Math.Abs(resultado);
                retorno = resultado.ToString();
            }
            else
            {
                retorno = "Valor inválido";
            }
            return retorno;
        }

        /// <summary>
        /// Convertirán un número decimal a binario, en caso de ser posible. Caso contrario retornará "Valor inválido". Reutilizar código.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            string retorno = "Valor inválido";

            if(numero < 11111111)
            {
                int parteEnteraAbsoluta = Math.Abs((int)numero);
                retorno = Convert.ToString(parteEnteraAbsoluta, 2);
            }
            return retorno;
        }

        public string DecimalBinario(string numero)
        {
            string retorno = "Valor inválido";
            bool esNumerico = double.TryParse(numero, out double numeroAConvertir);

            if (esNumerico)
            {
                retorno = this.DecimalBinario(numeroAConvertir);
            }

            return retorno;
        }
    }
}
