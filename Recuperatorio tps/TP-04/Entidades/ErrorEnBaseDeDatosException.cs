using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ErrorEnBaseDeDatosException : Exception
    {
        public ErrorEnBaseDeDatosException()
            : base()
        {

        }

        public ErrorEnBaseDeDatosException(string msj)
            : base(msj)
        {

        }

        public ErrorEnBaseDeDatosException(string msj, Exception ex)
            :base(msj, ex)
        {

        }
    }
}
