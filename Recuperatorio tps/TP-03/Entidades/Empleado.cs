using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {        
        public static double valorHora;
        protected DateTime horaEntrada;
        protected DateTime horaSalida;
        protected float caja;
        protected List<Cliente> clientes;
        protected string legajo;

        public Empleado() 
            :base()
        {
            this.clientes = new List<Cliente>();
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Empleado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        public Empleado(string nombre, string apellido, int dni, string nroTelefono, string direccion, DateTime horaEntrada, DateTime horaSalida)
            :this()

        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.horaEntrada = horaEntrada;
            this.horaSalida = horaSalida;
            this.nroTelefono = nroTelefono;
            this.dni = dni;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.Nombre);
            retorno.AppendLine(" " + base.Apellido);


            return retorno.ToString();
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            
            retorno.Append(base.Mostrar());
            retorno.AppendLine(this.HoraEntrada.ToString());
            retorno.AppendLine(this.HoraSalida.ToString());
            retorno.Append(this.Caja.ToString());

            return retorno.ToString();
        }

        public override float CalcularCaja()
        {
            float retorno = 0;

            foreach(Cliente aux in this.Clientes)
            {
                retorno = retorno + aux.Importe;
            }              
            return retorno;
        }



        #region propiedades


        public DateTime HoraEntrada
        {
            get { return this.horaEntrada; }
            set { this.horaEntrada = value; }
        }

        public DateTime HoraSalida
        {
            get { return this.horaSalida; }
            set { this.horaSalida = value; }
        }

        public float Caja
        {
            get { return this.caja; }
            set { this.caja = value; }
        }

        public List<Cliente> Clientes
        {
            get { return this.clientes; }
            set { this.clientes = value; }
        }

        #endregion

    }
}
