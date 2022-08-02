using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>\

    
    public sealed class Taller
    {
        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }

        private List<Vehiculo> vehiculos;
        private int espacioDisponible;
        

        #region "Constructores"
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Taller(int espacioDisponible)
            :this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        public override string ToString()
        {
            return Listar(this, ETipo.Todos);
        }
        #endregion


        #region "Métodos"

        public static string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat("Tenemos " + taller.vehiculos.Count + " lugares ocupados de un total de " + taller.espacioDisponible  + " disponibles");
            retorno.AppendLine("");
            foreach (Vehiculo v in taller.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.Ciclomotor:
                        if (v is Ciclomotor) retorno.AppendLine(((Ciclomotor)v).Mostrar());
                        break;
                    case ETipo.Sedan:
                        if (v is Sedan) retorno.AppendLine(((Sedan)v).Mostrar());
                        break;
                    case ETipo.SUV:
                        if (v is Suv) retorno.AppendLine(((Suv)v).Mostrar());
                        break;
                    default:
                        retorno.AppendLine(v.Mostrar());
                        break;
                }
            }

            return retorno.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            if (taller.vehiculos.Count < taller.espacioDisponible)
            {
                foreach (Vehiculo v in taller.vehiculos)
                {
                    if (v.Equals(vehiculo))
                    {
                        return taller;
                    }
                }
                taller.vehiculos.Add(vehiculo);
            }

            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                {
                    taller.vehiculos.Remove(v);
                    break;
                }
            }
            return taller;
        }
        #endregion
    }
}
