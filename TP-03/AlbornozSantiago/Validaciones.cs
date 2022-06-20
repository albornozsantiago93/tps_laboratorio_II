using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbornozSantiago
{
    public class Validaciones
    {
        public static int ValidarDni(string dni)
        {
            int dniAux = 0000000;

            if (int.TryParse(dni, out dniAux))
            {
                return dniAux;
            }

            return dniAux;
        }

        public static int ValidarNroDeTelfono(string telefono)
        {
            int nroDeTelefono = 0;

            if (int.TryParse(telefono, out nroDeTelefono))
            {
                return nroDeTelefono;
            }

            return nroDeTelefono;
        }

        public static float ValidarPrecio(string precio)
        {
            int precioAux = 0;

            if (int.TryParse(precio, out precioAux))
            {
                return precioAux;
            }

            return precioAux;
        }
    }
}
